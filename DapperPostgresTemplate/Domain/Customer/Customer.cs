namespace DapperPostgresTemplate.Domain.Customer
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string city { get; set; }
        public DateTime createdate { get; set; }
    }
}
