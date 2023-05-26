using RepairBikeService.Api.Models;

namespace RepairBikeService.Api.Repositories
{
    public class RepairRequestRepository : IRepairRequestRepository
    {
        private readonly RepairingDbContext _context;

        public RepairRequestRepository(RepairingDbContext context)
        {
            _context = context;
        }

        public async Task<RepairRequest> AddRepairRequestToDatabase(RepairRequest repairRequest)
        {
            _context.RepairRequests.Add(repairRequest);
            await _context.SaveChangesAsync();

            return repairRequest;
        }
    }
}
