using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MyScriptureJournal.Models
{
    public class Canon
    {
        [Display(Name = "Canon")]
        public int CanonId { get; set; }

        [Display(Name = "Canon")]
        public string CanonName { get; set; }
    }
}
