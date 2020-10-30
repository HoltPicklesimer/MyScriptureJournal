﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Data
{
    public class MyScriptureJournalContext : DbContext
    {
        public MyScriptureJournalContext (DbContextOptions<MyScriptureJournalContext> options)
            : base(options)
        {
        }

        public DbSet<MyScriptureJournal.Models.JournalEntry> JournalEntry { get; set; }
        public DbSet<MyScriptureJournal.Models.Book> Book { get; set; }
        public DbSet<MyScriptureJournal.Models.Canon> Canon { get; set; }
    }
}