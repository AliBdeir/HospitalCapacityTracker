using HospitalBedTracker.Data;
using HospitalBedTracker.Data.DataTypes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
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

        [ViewData]
        public List<HospitalBedSection> BedSections { get; set; }

        [BindProperty]
        public List<HospitalBedSection> NewSections { get; set; }

        [BindProperty]
        public Dictionary<string, string> SectionValues { get; set; }

        public HospitalManagerPageModel(ILogger<HospitalManagerPageModel> logger,
            ApplicationDbContext context)
        {
            this.logger = logger;
            this.db = context;
        }

        public void OnGet()
        {
            logger.LogInformation("Retrieving current user ID...");
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            logger.LogInformation($"Found hospital ID of {userId}");
            logger.LogInformation($"Retrieving hospital sections....");
            this.BedSections = db.HospitalBedSections.Where(x => x.HospitalId == userId).ToList();
            logger.LogInformation($"Found {this.BedSections.Count} bed sections for hospital of ID {userId}");
        }

        public async Task OnPost()
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            logger.LogInformation($"Submit button POST called. Received {NewSections.Count} HospitalBedSection objects for USERID {userId}");
            using var transaction = await db.Database.BeginTransactionAsync();
            try
            {
                List<HospitalBedSection> sections = db.HospitalBedSections.Where(x => x.HospitalId == userId).ToList();
                db.RemoveRange(sections);
                logger.LogInformation("Updating received objects with hospital ID...");
                for (int i = 0; i < sections.Count; i++)
                {
                    sections[i].HospitalId = userId;
                }
                logger.LogInformation("Adding new records to database...");
                await db.AddRangeAsync(sections);
                await db.SaveChangesAsync();
                logger.LogInformation($"Successfully added new hospital bed sections for USERID {userId}");
                await transaction.CommitAsync();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}
