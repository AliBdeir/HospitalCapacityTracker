using HospitalBedTracker.Data;
using HospitalBedTracker.Data.DataTypes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalBedTracker.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> logger;
        private readonly ApplicationDbContext db;

        #region Properties
        [ViewData]
        public List<Hospital> Hospitals { get; set; } = new List<Hospital>();
        #endregion

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            this.logger = logger;
            this.db = context;
        }

        public async Task OnGetAsync() {
            this.Hospitals = db.Hospitals.Include(x => x.HospitalNames).Include(x => x.HospitalAddresses).Include(x => x.HospitalBedSections).ToList();
        }
    }
}
