using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HospitalBedSystem.Data.DataTypes
{
    public class BedType
    {
        [Key]
        public int BedCategoryId { get; set; }

        [MaxLength(32)]
        [Required]
        public string Name { get; set; }

    }
}
