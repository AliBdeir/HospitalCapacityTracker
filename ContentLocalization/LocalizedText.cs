using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalBedTracker.Data.DataTypes
{

    public abstract class LocalizedText
    {
        [Key]
        public int LocalizedTextId { get; set; }

        [MaxLength(5)]
        [Required]
        public string LanguageISO { get; set; }

        [Required]
        public virtual string Text { get; set; }

    }
}
