using EmployeeApp.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInformation.Migrations
{
    public class EmployeeInformationDataBaseContext: DbContext
    {
        public EmployeeInformationDataBaseContext(DbContextOptions<EmployeeInformationDataBaseContext> options) : base(options)
        {
        }

        public DbSet<EmployeeInfo> EmployeeInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeInfo>().ToTable("EmployeeInfos");
        }
    }
}
