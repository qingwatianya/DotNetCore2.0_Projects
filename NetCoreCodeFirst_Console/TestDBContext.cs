using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using NetCoreCodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace NetCoreCodeFirst_Console
{
   public class TestDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseMySql("server=xxx;database=rensanqian;user=xxx;password=xxx;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User2>().HasIndex(u => u.Account).IsUnique();
        }

        //public DbSet<User> User { get; set; }
        public DbSet<User2> User2 { get; set; }



    }
}
