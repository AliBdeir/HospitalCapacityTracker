using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalBedTracker.Data.DataTypes
{
    public abstract class HospitalLocalization : LocalizedText
    {
        public string HospitalId { get; set; }
    }
    public class HospitalName : HospitalLocalization
    {
        [MaxLength(64)]
        public override string Text { get => base.Text; set => base.Text = value; }
    }

    public class HospitalAddress : HospitalLocalization
    {
        [MaxLength(512)]
        public override string Text { get => base.Text; set => base.Text = value; }
    }

}
