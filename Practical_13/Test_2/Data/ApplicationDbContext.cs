using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Test_2.Models;

namespace Test_2.Data
{
	public class ApplicationDbContext:DbContext
	{
        public ApplicationDbContext() : base("name=Employee_Db_Practical_13")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Employee2> Employees { get; set; }
        public DbSet<Designation> Designations { get; set; }
    }
}