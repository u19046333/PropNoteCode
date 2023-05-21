using WebApi.Models;

namespace WebApi.Models
{
    public class Tenant : AppUser
    {
        public int TenantID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyEmail { get; set; }
    }
}
