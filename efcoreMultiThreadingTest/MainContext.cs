using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EFCoreMultiThreading
{
    public class MainContext : DbContext
    {
        public MainContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = localhost;Initial Catalog=MultiTHreading;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var student = modelBuilder.Entity<Student>();
            student.HasKey(s => s.Guid);
            student.HasOne(s => s.School).WithMany(s => s.Students).HasForeignKey(s => s.SchoolGuid);
            student.HasMany(s => s.Backpacks).WithOne(s => s.Student).HasForeignKey(s => s.StudentGuid);

            var school = modelBuilder.Entity<School>();
            school.HasKey(s => s.Guid);
            school.HasMany(s => s.Students).WithOne(s => s.School).HasForeignKey(s => s.SchoolGuid);

            var backacb = modelBuilder.Entity<Backpack>();
            backacb.HasKey(s => s.Guid);
            backacb.HasOne(s => s.Student).WithMany(s => s.Backpacks).HasForeignKey(s => s.StudentGuid);
            base.OnModelCreating(modelBuilder);
        }

        public EntityQuery<T> GetEntities<T>() where T : class
        {
            return new EntityQuery<T>(Set<T>().AsQueryable());
        }
    }
}
