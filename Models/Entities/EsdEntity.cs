using DirectoryWebApi.Models.Resources;

namespace DirectoryWebApi.Models.Entities
{
    public class EsdEntity : BaseEntity
    {
        public string AdministratorName { get; set; }

        public EsdEntity(Esd resource)
        {
            this.Id = resource.Id;
            this.Name = resource.Name;
            this.Code = resource.Code;
            this.AddressLine1 = resource.AddressLine1;
            this.AddressLine2 = resource.AddressLine2;
            this.State = resource.State;
            this.AdministratorName = resource.AdministratorName;
            this.Phone = resource.Phone;
            this.Email = resource.Email;
            this.ZipCode = resource.ZipCode;
        }

        public EsdEntity()
        {
        }
    }
}
