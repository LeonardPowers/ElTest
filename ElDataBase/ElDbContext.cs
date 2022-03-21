using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElTest.Model;
using Microsoft.EntityFrameworkCore;

namespace ElDataBase
{
    public class ElDbContext : DbContext
    {
        public DbSet<ElClient> ElClient { get; set; }
        public DbSet<ElRequest> ElRequest { get; set; }

        public ElDbContext()
        {
            Database.EnsureDeleted();  
            Database.EnsureCreated();  
        }


        public ElDbContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-4K8F29S\SQLEXPRESS; Database=ElBase; Trusted_Connection=True; MultipleActiveResultSets=true");
        }
    }

}
