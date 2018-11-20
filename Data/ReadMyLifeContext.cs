using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ReadMyLife.Models
{
    public class ReadMyLifeContext : DbContext
    {
        public ReadMyLifeContext (DbContextOptions<ReadMyLifeContext> options)
            : base(options)
        {
        }

        public DbSet<ReadMyLife.Models.StoryItem> StoryItem { get; set; }
    }
}
