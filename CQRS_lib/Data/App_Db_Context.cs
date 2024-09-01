using CQRS_lib.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_lib.Data
{
    public class App_Db_Context : DbContext
    {
        public App_Db_Context(DbContextOptions<App_Db_Context> options): base(options) { }
       
        public DbSet<Items> Items { get; set; }

    }
}
