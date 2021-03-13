using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext 
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        //tinfo200:[2021-03-12-ijk22701-dykstra1] - Below are the things that will be added to the data model
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //tinfo200:[2021-03-12-ijk22701-dykstra1] - Creates tables for the above data types with the names "Course", "Enrollment", and "Student"
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}