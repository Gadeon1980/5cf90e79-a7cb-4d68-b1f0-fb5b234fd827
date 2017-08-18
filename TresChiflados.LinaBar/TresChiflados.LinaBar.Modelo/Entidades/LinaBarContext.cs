using System;
using System.Collections.Generic;
using System.Data.Entity;
using TresChiflados.LinaBar.Modelo.Migrations;

namespace TresChiflados.LinaBar.Modelo.Entidades
{
    public class LinaBarContext : DbContext
    {
        public LinaBarContext() : base("LinaBarContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LinaBarContext, Configuration>("LinaBarContext"));
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
