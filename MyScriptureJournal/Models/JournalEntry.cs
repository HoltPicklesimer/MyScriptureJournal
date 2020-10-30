using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJournal.Models
{
    public class JournalEntry
    {
        public int JournalEntryId { get; set; }

        [Display(Name = "Entry Date")]
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime EntryDate { get; set; }

        [Display(Name = "Book")]
        [Required]
        public int BookId { get; set; }

        [StringLength(20, MinimumLength = 1)]
        [Required]
        public string Chapter { get; set; }

        [StringLength(20, MinimumLength = 1)]
        [Required]
        public string Verse { get; set; }

        [StringLength(300, MinimumLength = 3)]
        [Required]
        public string Note { get; set; }

        // Navigation Properties
        public Book Book { get; set; }
    }
}
