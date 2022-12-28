using Microsoft.EntityFrameworkCore;
using StudentAccounting.Model.DataBaseModels;

namespace StudentAccounting.Model
{
    public class ApplicationDatabaseContext : DbContext
    {
        //public ApplicationDatabaseContext()
        //{
        //    Database.EnsureCreated();
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder _context)
        {
            _context.UseSqlServer("Server=STASVCODE\\SQLEXPRESS;DataBase=StudentAccounting;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Bonus> Bonuses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Individuals> Individuals { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Participants> Participants { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectExecutor> ProjectExecutor { get; set; }
        public DbSet<Rang> Rangs { get; set; }
        public DbSet<Student> Students {get; set;}
    }
}
