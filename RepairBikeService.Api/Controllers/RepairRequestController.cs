using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using RepairBikeService.Api.Models;
using RepairBikeService.Api.Repositories;

namespace RepairBikeService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepairRequestController : ControllerBase
    {
        private readonly IRepairRequestRepository _repairRequestRepository;

        public RepairRequestController(IRepairRequestRepository repairRequestRepository)
        {
            _repairRequestRepository = repairRequestRepository;
        }

        [HttpPost]
        [EnableCors]
        public async Task<IActionResult> Post(RepairRequest repairRequest)
        {
            if (ModelState.IsValid)
            {
                await _repairRequestRepository.AddRepairRequestToDatabase(repairRequest);
                return Ok(repairRequest);
            }

            return BadRequest(ModelState);
        }
    }
}
