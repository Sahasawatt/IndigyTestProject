
using Microsoft.EntityFrameworkCore;
using indigyTestProject.Model.Model.Entities;

namespace indigyTestProject.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.Id)
                    .HasColumnName("EMPNO");
                entity.Property(e => e.FirstName)
                    .HasColumnName("FIRST_NAME");
                entity.Property(e => e.LastName)
                    .HasColumnName("LAST_NAME");
                entity.Property(e => e.Designation)
                    .HasColumnName("DESIGNATION");
                entity.Property(e => e.HireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("HIRE_DATE");
                entity.Property(e => e.Salary)
                    .HasColumnName("SALARY");
                entity.Property(e => e.Comm)
                    .HasColumnName("COMM");
                entity.Property(e => e.DeptNo)
                    .HasColumnName("DEPT_NO");
            });
        }
    }
}
