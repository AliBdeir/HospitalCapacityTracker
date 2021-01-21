using HospitalBedTracker.Data.DataTypes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalBedTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext<Hospital>
    {
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<BedType> BedTypes { get; set; }
        public DbSet<HospitalBedSection> HospitalBedSections { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
