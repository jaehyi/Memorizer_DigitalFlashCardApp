using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Memorizer.Models
{
    public class MemorizerDbContext : DbContext
    {
        public MemorizerDbContext(DbContextOptions<MemorizerDbContext> options) : base(options)
        {

        }
        public DbSet<FlashCard> FlashCards { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
