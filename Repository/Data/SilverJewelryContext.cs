using Repository.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repository.Data.Entity;

namespace Repository.Data
{
    public class SilverJewelryContext : DbContext
    {
        public SilverJewelryContext(DbContextOptions<SilverJewelryContext> options) : base(options) { }

        public DbSet<BranchAccount> BranchAccounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SilverJewelry> SilverJewelries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
