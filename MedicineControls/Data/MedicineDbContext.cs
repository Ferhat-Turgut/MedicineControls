using MedicineControls.Models;
using Microsoft.EntityFrameworkCore;

namespace MedicineControls.Data
{
    public class MedicineDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Usage> Usages { get; set; }
        public DbSet<HoursOfUse> HoursOfUses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MedicineControls;Integrated Security=True");
        }
    }
}
