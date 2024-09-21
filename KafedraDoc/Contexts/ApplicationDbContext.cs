using KafedraDoc.Models;
using Microsoft.EntityFrameworkCore;

namespace KafedraDoc.Contexts 
{
    /// <summary>
    /// Контекст базы данных для приложения.
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Определение DbSet для каждой модели
        public DbSet<CurriculumProgram> CurriculumPrograms { get; set; }
        public DbSet<DepartmentMeetingMinutes> MeetingMinutes { get; set; }
        public DbSet<EmployeePersonalFile> EmployeeFiles { get; set; }
        public DbSet<Agreement> Agreements { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        // Настройка подключения к базе данных
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("YourConnectionStringHere"); // Замените на вашу строку подключения
            }
        }
    }
}