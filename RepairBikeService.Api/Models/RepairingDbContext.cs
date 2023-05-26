using Microsoft.EntityFrameworkCore;

namespace RepairBikeService.Api.Models
{
    public class RepairingDbContext : DbContext
    {
        public RepairingDbContext(DbContextOptions<RepairingDbContext> options) : base(options) { }
        public DbSet<RepairRequest> RepairRequests { get; set; }
    }
}
