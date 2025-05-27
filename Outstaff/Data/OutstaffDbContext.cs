using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Outstaff.Models;

namespace Outstaff.Data
{
    public class OutstaffDbContext : DbContext
    {
            public OutstaffDbContext(DbContextOptions<OutstaffDbContext> options)
                : base(options)
            {
            }
            public DbSet<Contractor> Contractor { get; set; }
        public DbSet<Contract> Contract { get; set; }
        public DbSet<SupplementaryAgreement> SupplementaryAgreement { get; set; }
        public DbSet<Rate> Rate { get; set; }
        public DbSet<Specialist> Specialist { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Assignment> Assignment { get; set; }
        public DbSet<WorkLog> WorkLog { get; set; }
        public DbSet<ReportPeriod> ReportPeriod { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Outstaff;Username=postgres;Password=123");
        }
    }
}
