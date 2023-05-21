using WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LeaseController : Controller
    {
        public readonly IRepository _repository;

        public LeaseController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("GetAllLeases")]
        public async Task<IActionResult> GetAllLeases()
        {
            try
            {
                var allLeases = await _repository.GetAllLeasesAsync();
                List<LeaseResponse> leases = new List<LeaseResponse>();
                foreach (var lease in allLeases)
                {
                    leases.Add(new LeaseResponse
                    {
                        StartDate = lease.StartDate,
                        EndDate = lease.EndDate,
                        PropertyDescription = lease.Property.Description,
                        TenantName = lease.Tenant.Name
                    });
                }

                return Ok(leases);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal Server Error, please contact support");
            }
        }
        [HttpPost]
        [Route("AddLease")]
        public async Task<IActionResult> AddLease(LeaseRequest leaseRequest)
        {

            var lease = new Lease
            {
                StartDate = leaseRequest.StartDate,
                EndDate = leaseRequest.EndDate,
                TenantID = leaseRequest.TenantID,
                PropertyID = leaseRequest.PropertyID
            };
            await _repository.AddLease(lease);
            return Ok(lease);
        }
    }
}

