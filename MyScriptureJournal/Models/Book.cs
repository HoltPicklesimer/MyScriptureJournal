using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public class Book
    {
        [Display(Name = "Book")]
        public int BookId { get; set; }
        public int CanonId { get; set; }

        [Display(Name = "Book")]
        public string BookName { get; set; }

        // Navigation Properties
        public Canon Canon { get; set; }
    }
}
