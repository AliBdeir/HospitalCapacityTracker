using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalBedTracker.Data;
using HospitalBedTracker.Data.DataTypes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HospitalBedTracker.Pages
{
    public class AdminPageModel : PageModel
    {
        private readonly ILogger<AdminPageModel> logger;
        private readonly ApplicationDbContext db;

        #region Binded Properties
        [BindProperty]
        public Dictionary<string, string> HospitalNames { get; set; }

        [BindProperty]
        public Dictionary<string, string> HospitalAddresses { get; set; }

        [BindProperty]
        public string HospitalGoogleMapsUrl { get; set; }

        [BindProperty]
        public string HospitalImageUrl { get; set; }
        #endregion

        public AdminPageModel(ILogger<AdminPageModel> logger, ApplicationDbContext context)
        {
            this.logger = logger;
            this.db = context;
        }

        public void OnGet()
        {
        }

        public async Task OnPostAsync()
        {
            //return new Hospital()
            //{

            //}
        }

    }
}
