using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tHISiStHEsHOP.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string userRoleName = "user";

            string userEmail = "alex@mail.ru";
            string userPassword = "123456";

            Role userRole = new Role { Id = 1, Name = userRoleName };
            User userUser = new User { Id = 1, Email = userEmail, Password = userPassword, RoleId = userRole.Id };

            modelBuilder.Entity<Role>().HasData(new Role[] { userRole });
            modelBuilder.Entity<User>().HasData(new User[] { userUser });
            base.OnModelCreating(modelBuilder);
        }
    }
}
