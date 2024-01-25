using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koncertWpfEf.Models
{
    public class KoncertContext : DbContext
    {
        public readonly string connStr = "server=localhost;userid=root;password=;database=koncert";

   
         
        public DbSet<Koncert> Koncertek { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connStr, ServerVersion.AutoDetect(connStr));
        }

       
    }
}
