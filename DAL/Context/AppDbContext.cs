using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DAL.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {

            Database.Connection.ConnectionString= @"server=DESKTOP-2UBTK8M\SQLEXPRESS01;database=PersonelDB;Integrated Security=true";
        }
        public DbSet<Personnel> Personnels { get; set; }
    }
}