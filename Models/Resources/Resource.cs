namespace DirectoryWebApi.Models.Resources
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
