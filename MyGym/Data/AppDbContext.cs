using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyGym.Models;

namespace MyGym.Data
{
    public class AppDbContext:IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipment_Training>().HasKey(et => new { 
                et.EquipmentId,
                et.TrainingId
            });

            modelBuilder.Entity<Equipment_Training>().HasOne(t => t.Training).WithMany(et => et.Equipments_Trainings).HasForeignKey(t => t.TrainingId);

            modelBuilder.Entity<Equipment_Training>().HasOne(e => e.Equipment).WithMany(et => et.Equipments_Trainings).HasForeignKey(e => e.EquipmentId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Training> Trainings { get; set; }

        public DbSet<Equipment_Training> Equipments_Trainings { get; set; }

        public DbSet<TrainingCenter> TrainingCenters { get; set; }

        public DbSet<Coach> Coaches { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
