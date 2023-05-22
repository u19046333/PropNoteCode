using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Migrations;
using WebApi.Models.Admin;
using WebApi.ViewModels;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public AdminController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        [Route("GetAllContractorType")]
        public async Task<IActionResult> GetAllContractorTypes()
        {
            try
            {
                IQueryable<ContractorType> query = _appDbContext.ContractorTypes;
                var results = await query.ToArrayAsync();
                return Ok(results);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error. Please contact support.");
            }
        }

        [HttpGet]
        [Route("GetContractorType/{ContractorTypeId}")]
        public async Task<IActionResult> GetContractorType(int ContractorTypeId)
        {
            try
            {
                IQueryable<ContractorType> query = _appDbContext.ContractorTypes.Where(c => c.ContractorTypeId == ContractorTypeId);
                var result = await query.FirstOrDefaultAsync();

                if (result == null) return NotFound("ContractorType does not exist");

                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error. Please contact support");
            }
        }
        [HttpPost]
        [Route("AddContractorType")]
        public async Task<IActionResult> AddContractorType(string cvm)
        {
            var contractorType = new ContractorType { ContractorTypeName = cvm };

            try
            {
                _appDbContext.ContractorTypes.Add(contractorType);
                await _appDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                return BadRequest("Invalid transaction");
            }

            return Ok(contractorType);
        }

        [HttpPut]
        [Route("EditContractorType/{ContractorTypeId}")]
        public async Task<ActionResult<ContractorTypeViewModel>> EditContractorType(int ContractorTypeId, string contractorTypeModel)
        {
            try
            {
                ContractorType existingContractorType = (ContractorType)await GetContractorType(ContractorTypeId);
                if (existingContractorType == null) return NotFound($"The Contractor Type does not exist");

                existingContractorType.ContractorTypeName = contractorTypeModel;
                if (await _appDbContext.SaveChangesAsync())
                {
                    return Ok(existingContractorType);
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error. Please contact support.");
            }
            return BadRequest("Your request is invalid.");
        }

        [HttpDelete]
        [Route("DeleteContractorType/{ContractorTypeId}")]
        public async Task<IActionResult> DeleteContractorType(int ContractorTypeId)
        {
            try
            {
                var existingContractorType = await GetContractorType(ContractorTypeId);
                if (existingContractorType == null) return NotFound($"The Contractor Type does not exist");

                _appDbContext.Remove(existingContractorType);
                if (await _appDbContext.SaveChangesAsync())
                    return Ok(existingContractorType);

            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error. Please contact support.");
            }
            return BadRequest("Your request is invalid.");
        }

        [HttpGet]
        [Route("GetAllSnagListItems")]
        public async Task<IActionResult> GetAllSnagListItems()
        {
            try
            {
                IQueryable<SnagListItem> query = _appDbContext.SnagListItems;
                var results = await query.ToArrayAsync();
                return Ok(results);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error. Please contact support.");
            }
        }

        [HttpGet]
        [Route("GetSnagListItem/{SnagListItemId}")]
        public async Task<IActionResult> GetSnagListItems(int SnagListItemsId)
        {
            try
            {
                IQueryable<SnagListItem> query = _appDbContext.SnagListItems.Where(c => c.SnagListItemId == SnagListItemsId);
                var result = await query.FirstOrDefaultAsync();

                if (result == null) return NotFound("Snag List Item does not exist");

                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error. Please contact support");
            }
        }
        [HttpPost]
        [Route("AddSnagListItem")]
        public async Task<IActionResult> AddSnagListItem(string cvm)
        {
            var snagListItem = new SnagListItem { SnagListItemDescription = cvm };
            try
            {
                _appDbContext.SnagListItems.Add(snagListItem);
                await _appDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                return BadRequest("Invalid transaction");
            }

            return Ok(snagListItem);
        }

        [HttpPut]
        [Route("EditSnagListItem/{SnagListItemId}")]
        public async Task<ActionResult<SnagListItemViewModel>> EditSnagListItem(int SnagListItemId, string SnagListItemModel)
        {
            try
            {
                SnagListItem existingSnagListItem = (SnagListItem)await GetSnagListItems(SnagListItemId);
                if (existingSnagListItem == null) return NotFound($"The Contractor Type does not exist");

                existingSnagListItem.SnagListItemDescription = SnagListItemModel;
                if (await _appDbContext.SaveChangesAsync())
                {
                    return Ok(existingSnagListItem);
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error. Please contact support.");
            }
            return BadRequest("Your request is invalid.");
        }

        [HttpDelete]
        [Route("DeleteSnagListItem/{SnagListItemId}")]
        public async Task<IActionResult> DeleteSnagListItem(int SnagListItemId)
        {
            try
            {
                var existingSnagListItem = await GetContractorType(SnagListItemId);
                if (existingSnagListItem == null) return NotFound($"The Contractor Type does not exist");

                _appDbContext.Remove(existingSnagListItem);
                if (await _appDbContext.SaveChangesAsync())
                    return Ok(existingSnagListItem);

            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error. Please contact support.");
            }
            return BadRequest("Your request is invalid.");
        }

    }
}
