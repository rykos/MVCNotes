using Microsoft.EntityFrameworkCore;
using MVCNote.Models;

namespace MVCNote.Data
{
    public class MvcNoteContext : DbContext
    {
        public MvcNoteContext(DbContextOptions<MvcNoteContext> options) : base(options)
        {
        }

        public DbSet<Note> Note { get; set; }
    }
}