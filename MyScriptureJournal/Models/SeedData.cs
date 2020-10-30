using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJournal.Data;
using System;
using System.Linq;

namespace MyScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any books
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Canon.AddRange(
                    new Canon() { CanonName = "Old Testament" },
                    new Canon() { CanonName = "New Testament" },
                    new Canon() { CanonName = "Book of Mormon" },
                    new Canon() { CanonName = "Doctrine and Covenants" },
                    new Canon() { CanonName = "Pearl of Great Price" }
                );

                context.SaveChanges();

                context.Book.AddRange(
                    // Old Testament
                    new Book() { BookName = "Genesis", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Exodus", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Leviticus", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Numbers", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Deuteronomy", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Joshua", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Judges", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Judges", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Ruth", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "1 Samuel", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "2 Samuel", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "1 Kings", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "2 Kings", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "1 Chronicles", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "2 Chronicles", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Ezra", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Nehemiah", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Esther", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Job", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Psalms", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Proverbs", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Ecclesiastes", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Song of Solomon", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Isaiah", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Jeremiah", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Lamentations", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Ezekiel", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Daniel", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Hosea", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Joel", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Amos", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Obadiah", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Jonah", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Micah", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Nahum", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Habakkuk", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Zephaniah", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Haggai", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Zechariah", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },
                    new Book() { BookName = "Malachi", CanonId = context.Canon.Single(c => c.CanonName == "Old Testament").CanonId },

                    // New Testament
                    new Book() { BookName = "Matthew", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "Mark", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "Luke", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "John", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "Acts", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "Romans", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "1 Corinthians", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "2 Corinthians", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "Galations", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "Ephesians", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "Philippians", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "Colossians", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "1 Thessalonians", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "2 Thessalonians", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "1 Timothy", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "2 Timothy", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "Titus", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "Philemon", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "Hebrews", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "James", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "1 Peter", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "2 Peter", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "1 John", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "2 John", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "3 John", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "Jude", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },
                    new Book() { BookName = "Revelation", CanonId = context.Canon.Single(c => c.CanonName == "New Testament").CanonId },

                    // Book of Mormon
                    new Book() { BookName = "1 Nephi", CanonId = context.Canon.Single(c => c.CanonName == "Book of Mormon").CanonId },
                    new Book() { BookName = "2 Nephi", CanonId = context.Canon.Single(c => c.CanonName == "Book of Mormon").CanonId },
                    new Book() { BookName = "Jacob", CanonId = context.Canon.Single(c => c.CanonName == "Book of Mormon").CanonId },
                    new Book() { BookName = "Enos", CanonId = context.Canon.Single(c => c.CanonName == "Book of Mormon").CanonId },
                    new Book() { BookName = "Jarom", CanonId = context.Canon.Single(c => c.CanonName == "Book of Mormon").CanonId },
                    new Book() { BookName = "Omni", CanonId = context.Canon.Single(c => c.CanonName == "Book of Mormon").CanonId },
                    new Book() { BookName = "Words of Mormon", CanonId = context.Canon.Single(c => c.CanonName == "Book of Mormon").CanonId },
                    new Book() { BookName = "Mosiah", CanonId = context.Canon.Single(c => c.CanonName == "Book of Mormon").CanonId },
                    new Book() { BookName = "Alma", CanonId = context.Canon.Single(c => c.CanonName == "Book of Mormon").CanonId },
                    new Book() { BookName = "Helaman", CanonId = context.Canon.Single(c => c.CanonName == "Book of Mormon").CanonId },
                    new Book() { BookName = "3 Nephi", CanonId = context.Canon.Single(c => c.CanonName == "Book of Mormon").CanonId },
                    new Book() { BookName = "4 Nephi", CanonId = context.Canon.Single(c => c.CanonName == "Book of Mormon").CanonId },
                    new Book() { BookName = "Mormon", CanonId = context.Canon.Single(c => c.CanonName == "Book of Mormon").CanonId },
                    new Book() { BookName = "Ether", CanonId = context.Canon.Single(c => c.CanonName == "Book of Mormon").CanonId },
                    new Book() { BookName = "Moroni", CanonId = context.Canon.Single(c => c.CanonName == "Book of Mormon").CanonId },

                    // Doctrine and Covenants
                    new Book() { BookName = "Doctrine and Covenants Sections", CanonId = context.Canon.Single(c => c.CanonName == "Doctrine and Covenants").CanonId },
                    new Book() { BookName = "Official Declaration 1", CanonId = context.Canon.Single(c => c.CanonName == "Doctrine and Covenants").CanonId },
                    new Book() { BookName = "Official Declaration 2", CanonId = context.Canon.Single(c => c.CanonName == "Doctrine and Covenants").CanonId },

                    // Pearl of Great Price
                    new Book() { BookName = "Moses", CanonId = context.Canon.Single(c => c.CanonName == "Pearl of Great Price").CanonId },
                    new Book() { BookName = "Abraham", CanonId = context.Canon.Single(c => c.CanonName == "Pearl of Great Price").CanonId },
                    new Book() { BookName = "Joseph Smith - Matthew", CanonId = context.Canon.Single(c => c.CanonName == "Pearl of Great Price").CanonId },
                    new Book() { BookName = "Joseph Smith - History", CanonId = context.Canon.Single(c => c.CanonName == "Pearl of Great Price").CanonId },
                    new Book() { BookName = "Articles of Faith", CanonId = context.Canon.Single(c => c.CanonName == "Pearl of Great Price").CanonId }
                );

                context.SaveChanges();
            }
        }
    }
}