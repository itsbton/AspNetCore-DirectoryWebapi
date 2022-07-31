using DirectoryWebApi.Models.Resources;

namespace DirectoryWebApi.Models.Entities
{
    public class DistrictEntity : BaseEntity
    {
        public string AdministratorName { get; set; }
        public string City { get; set; }
        public string EsdCode { get; set; }
        public string EsdName { get; set; }
        public DistrictEntity() { }
        public DistrictEntity(District resource)
        {
            this.Id = resource.Id;
            this.Name = resource.Name;
            this.Code = resource.Code;
            this.AddressLine1 = resource.AddressLine1;
            this.AddressLine2 = resource.AddressLine2;
            this.State = resource.State;
            this.Phone = resource.Phone;
            this.Email = resource.Email;
            this.ZipCode = resource.ZipCode;

            this.City = resource.City;
            this.AdministratorName = resource.AdministratorName;
            this.EsdCode = resource.EsdCode;
            this.EsdName = resource.EsdName;
        }
    }
}
