using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TresChiflados.LinaBar.Modelo.Entidades
{
    public class LinaBarContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Problem> Problems { set; get; }


        public GIContext(): base("GIContext") 
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GIContext, Configuration>("GIContext"));
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
