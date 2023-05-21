namespace WebApi.Models
{
    public class Lease
    {
        public int LeaseID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TenantID { get; set; }
        public int PropertyID { get; set; }
        public Tenant? Tenant { get; set; }
        public Property? Property { get; set; }
    }
}
