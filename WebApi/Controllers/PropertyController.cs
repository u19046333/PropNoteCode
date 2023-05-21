using WebApi.Models;
using WebApi.ViewModels;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : Controller
    {
        public readonly IRepository _repository;

        public PropertyController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("GetAllProperties")]
        public async Task<IActionResult> GetAllProperties()
        {
            try
            {
                var allProperties = await _repository.GetAllPropertiesAsync();
                List<PropertyResponse> properties = new List<PropertyResponse>();
                foreach (var property in allProperties)
                {
                    properties.Add(new PropertyResponse
                    {
                        BrokerName = property.Broker.Name,
                        BuildingNumber = property.BuildingNumber,
                        Description = property.Description,
                        PurchaseAmount = property.PurchaseAmount,
                        PurchaseDate = property.PurchaseDate,
                        Size = property.Size,
                        Street = property.Street,
                        Suburb = property.Suburb,
                        Yard = property.Yard
                    });
                }

                return Ok(properties);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal Server Error, please contact support");
            }
        }
        [HttpPost]
        [Route("AddProperty")]
        public async Task<IActionResult> AddProperty(PropertyRequest propertyRequest)
        {

            var property = new Property
            {
               Yard = propertyRequest.Yard,
               BuildingNumber = propertyRequest.BuildingNumber,
               Description = propertyRequest.Description,   
               Suburb = propertyRequest.Suburb,
               Street = propertyRequest.Street,
               Size = propertyRequest.Size,
               PurchaseDate = propertyRequest.PurchaseDate,
               BrokerID = propertyRequest.BrokerID,
               PurchaseAmount = propertyRequest.PurchaseAmount,
               
            };
            await _repository.AddProperty(property);
            return Ok(property);
        }
    }
}
