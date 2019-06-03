using System;
using Microsoft.EntityFrameworkCore;
using qm.Models;

namespace WebApplication1.Models
{
    public class PgsqlDbContext : DbContext
    {
        public PgsqlDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Book> Book { get; set; }
    }
}
