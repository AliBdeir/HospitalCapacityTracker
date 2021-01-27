using HospitalBedTracker.Data;
using HospitalBedTracker.Data.DataTypes;
using Localization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HospitalBedTracker.Pages
{

    public class HospitalManagerPageModel : PageModel
    {
        private readonly ILogger<HospitalManagerPageModel> logger;
        private readonly ApplicationDbContext db;
        private readonly UserManager<Hospital> userManager;

        [ViewData]
        public List<HospitalBedSection> BedSections { get; set; }

        [BindProperty]
        public List<HospitalBedSection> NewSections { get; set; }

        [BindProperty]
        public Dictionary<string, string> SectionNames { get; set; } = new();

        public HospitalManagerPageModel(ILogger<HospitalManagerPageModel> logger,
            ApplicationDbContext context, UserManager<Hospital> userManager)
        {
            this.logger = logger;
            this.db = context;
            this.userManager = userManager;
        }

        public async Task<IActionResult> OnGet()
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            if (user?.Id == null || user.AdministratorAccount == false)
            {
                await new UnauthorizedResult().ExecuteResultAsync(PageContext);
                return new ForbidResult();
            }
            string userId = user.Id;
            logger.LogInformation("Retrieving current user ID...");
            logger.LogInformation($"Found hospital ID of {userId}");
            logger.LogInformation($"Retrieving hospital sections....");
            this.BedSections = db.HospitalBedSections.Include(x => x.BedCategory.BedTypeNames)
                .Where(x => x.HospitalId == userId).ToList();
            logger.LogInformation($"Found {this.BedSections.Count} bed sections for hospital of ID {userId}");
            return new PageResult();
        }

        public async Task<IActionResult> OnPost()
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            logger.LogInformation($"Submit button POST called. Received {NewSections.Count} HospitalBedSection objects for USERID {userId}");
            using var transaction = await db.Database.BeginTransactionAsync();
            try
            {
                List<HospitalBedSection> sections = db.HospitalBedSections.Where(x => x.HospitalId == userId).ToList();
                db.RemoveRange(sections);
                logger.LogInformation("Updating received objects with hospital ID...");
                List<HospitalBedSection> toAdd = new();
                for (int i = 0; i < NewSections.Count; i++)
                {
                    if (NewSections[i].BedCategory != null)
                    {
                        NewSections[i].BedCategory.BedTypeNames = NewSections[i].BedCategory.BedTypeNamesDict.ToLT<BedTypeName>().ToList();
                    }
                    var hospital = NewSections[i];
                    hospital.HospitalId = userId;
                    if (hospital.BedCategory == null || hospital.BedCategory.BedTypeNames.Count == 0
                        || hospital.BedCategory.BedTypeNames.All(x => string.IsNullOrWhiteSpace(x.Text)))
                    {
                        continue;
                    }
                    toAdd.Add(hospital);
                }
                logger.LogInformation("Adding new records to database...");
                await db.AddRangeAsync(toAdd);
                await db.SaveChangesAsync();
                logger.LogInformation($"Successfully added new hospital bed sections for USERID {userId}");
                await transaction.CommitAsync();
                return new RedirectResult("Index");
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}
