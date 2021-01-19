using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HospitalBedSystem.Data.DataTypes
{
    public class Hospital
    {
        [Key]
        public int HospitalId { get; set; }

        [MaxLength(64)]
        [Required]
        public string Name { get; set; }
        [MaxLength(256)]
        [Required]
        public string Address { get; set; }

        public List<HospitalBedSection> HospitalBedSection { get; set; }
    }
}