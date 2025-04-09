using Practical_13.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Practical_13.Data
{
	public class AppDbContext:DbContext
	{
        public AppDbContext() : base("name=Employee_Db_Practical_13")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}