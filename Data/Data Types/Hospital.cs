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
        [MaxLength(64)]
        [Required]
        public string Name { get; set; }
        [MaxLength(256)]
        [Required]
        public string Address { get; set; }

        public List<HospitalBedSection> HospitalBedSections { get; set; }
    }
}