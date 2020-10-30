using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace MyScriptureJournal.Pages.JournalEntries
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<JournalEntry> JournalEntry { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList Books { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Book { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortBy { get; set; }

        public async Task OnGetAsync()
        {
            // Get the Books for the select
            IQueryable<string> bookQuery = from e in _context.Book
                                            orderby e.BookName
                                            select e.BookName;

            var entries = from e in _context.JournalEntry
                                            .Include(e => e.Book)
                                            .Include(e => e.Book.Canon)
                          select e;

            if (!string.IsNullOrEmpty(SearchString))
            {
                entries = entries.Where(x => x.Note.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(Book))
            {
                entries = entries.Where(x => x.Book.BookName == Book);
            }

            if (!string.IsNullOrEmpty(SortBy))
            {
                switch(SortBy)
                {
                    case "Book":
                        entries = entries.OrderBy(x => x.Book.BookName)
                                         .ThenBy(x => x.Chapter)
                                         .ThenBy(x => x.Verse);
                        break;

                    case "EntryDate":
                        entries = entries.OrderBy(x => x.EntryDate);
                        break;
                }
            }

            Books = new SelectList(await bookQuery.Distinct().ToListAsync());
            JournalEntry = await entries.ToListAsync();
        }
    }
}
