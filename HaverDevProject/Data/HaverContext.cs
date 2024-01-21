using HaverDevProject.Models;
using HaverIndividualTest.Models;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.Data
{
    public class HaverContext : DbContext
    {
        public HaverContext(DbContextOptions<HaverContext> options) : base(options) 
        { 
        }

        public DbSet<Defect> Defects { get; set; }
        public DbSet<Drawing> Drawings { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<EngineerDispositionType> EngineerDispositionTypes { get; set; }
        public DbSet<FollowUpType> FollowUpTypes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemDefect> ItemDefects { get; set; }
        public DbSet<ItemDefectPhoto> ItemDefectPhotos { get; set; }
        public DbSet<Ncr> Ncrs { get; set; }
        public DbSet<OpDispositionType> OpDispositionTypes { get; set; }
        public DbSet<ProcessApplicable> ProcessApplicables { get; set; }
        public DbSet<ProductNumber> ProductNumbers { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        // Add NewModels instead
    }
}
