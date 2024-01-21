using HaverDevProject.Models;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.Data
{
    public class HaverContext : DbContext
    {
        public HaverContext(DbContextOptions<HaverContext> options) : base(options) 
        { 
        }

    }
}
