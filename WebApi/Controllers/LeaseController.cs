﻿using WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Lease;
using WebApi.Interfaces;
using WebApi.Models.Users;

namespace WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LeaseController : Controller
    {
        public readonly ILeaseRepository _leaseRepository;

        public LeaseController(ILeaseRepository LeaseRepository)
        {
            _leaseRepository = LeaseRepository;
        }

        [HttpGet]
        [Route("GetAllLeases")]
        public async Task<IActionResult> GetAllLeases()
        {
            try
            {
                var allLeases = await _leaseRepository.GetAllLeasesAsync();
                List<LeaseResponse> leases = new List<LeaseResponse>();
                foreach (var lease in allLeases)
                {
                    leases.Add(new LeaseResponse
                    {
                        StartDate = lease.StartDate,
                        EndDate = lease.EndDate,
                        PropertyDescription = lease.Property.Description,
                        TenantID = lease.TenantID,
                        MonthlyAmount = lease.MonthlyAmount,
                    });
                }

                return Ok(leases);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal Server Error, please contact support");
            }
        }
        [HttpGet]
        [Route("GetAllTenants")]
        public async Task<IActionResult> GetAllTenants()
        {
            try
            {
                var allTenants = await _leaseRepository.GetAllTenantsAsync();
                List<Tenant> tenants = new();
                foreach (var tenant in allTenants)
                {
                    tenants.Add(new Tenant
                    {
                        TenantID = tenant.TenantID,
                        CompanyNumber = tenant.CompanyNumber,
                        CompanyName = tenant.CompanyName
                    });
                }

                return Ok(tenants);
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
                PropertyID = leaseRequest.PropertyID,
                MonthlyAmount = leaseRequest.MonthlyAmount,
            };
            await _leaseRepository.AddLease(lease);
            return Ok(lease);
        }
    }
}

