using DemoAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DemoAPI.Context
{
    public class AppDBContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=DemoAPItest;Trusted_Connection=True;");
        }


       
    }
}
