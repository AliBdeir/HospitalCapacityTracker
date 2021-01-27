using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HospitalBedTracker.Data.DataTypes
{
    public class HospitalBedSection
    {
        [Key]
        public int HospitalBedCategoryId { get; set; }

        public int CurrentOccupation { get; set; }
        public int MaxCapacity { get; set; }

        public int BedCategoryId { get; set; }
        public BedType BedCategory { get; set; }

        public string HospitalId { get; set; }
        public Hospital Hospital { get; set; }
    }
}
