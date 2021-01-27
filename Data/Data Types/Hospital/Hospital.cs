using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HospitalBedTracker.Data.DataTypes
{
    
    public class Hospital : IdentityUser
    {
        public List<HospitalName> HospitalNames { get; set; } = new();
        public List<HospitalAddress> HospitalAddresses { get; set; } = new();

        [MaxLength(2048)]
        public string GoogleMapsUrl { get; set; }

        [MaxLength(2048)]
        public string HospitalImageUrl { get; set; }

        [Required]
        public bool AdministratorAccount { get; set; } = false;

        public List<HospitalBedSection> HospitalBedSections { get; set; } = new();
    }
}