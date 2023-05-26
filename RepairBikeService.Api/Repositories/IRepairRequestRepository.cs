using RepairBikeService.Api.Models;

namespace RepairBikeService.Api.Repositories
{
    public interface IRepairRequestRepository
    {
        Task<RepairRequest> AddRepairRequestToDatabase(RepairRequest repairRequest);
    }
}
