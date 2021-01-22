using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HospitalBedTracker.Data.DataTypes
{
    public class BedTypeName : LocalizedText
    {
        public int BedTypeId { get; set; }

        [MaxLength(32)]
        public override string Text { get => base.Text; set => base.Text = value; }
    }

    public class BedType
    {
        [Key]
        public int BedCategoryId { get; set; }
        public List<BedTypeName> BedTypeNames { get; set; }
    }
}
