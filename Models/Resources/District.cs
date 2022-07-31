using DirectoryWebApi.Models.Entities;

namespace DirectoryWebApi.Models.Resources
{
    public class District : Resource
    {
        public string AdministratorName { get; set; }
        public string City { get; set; }
        public string EsdCode { get; set; }
        public string EsdName { get; set; }
        public District()
        {

        }

        public District(DistrictEntity entity)
        {
            this.Id = entity.Id;
            this.Name = entity.Name;
            this.Code = entity.Code;
            this.AddressLine1 = entity.AddressLine1;
            this.AddressLine2 = entity.AddressLine2;
            this.State = entity.State;
            this.Phone = entity.Phone;
            this.Email = entity.Email;
            this.ZipCode = entity.ZipCode;

            this.AdministratorName = entity.AdministratorName;
            this.City = entity.City;
            this.EsdCode = entity.EsdCode;
            this.EsdName = entity.EsdName;
        }
    }
}
