using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DomestiGo.Models
{
    public class DomestiGoContext :DbContext
    {
        public DbSet<UserDb> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string workingDirectory = Directory.GetCurrentDirectory();
            string dbPath = Path.Combine(workingDirectory, "Database", "Database.db");

            options.UseSqlite($"Data Source={dbPath}");
        }
    }
}
