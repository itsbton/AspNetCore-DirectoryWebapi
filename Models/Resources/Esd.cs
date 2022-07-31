using DirectoryWebApi.Models.Entities;

namespace DirectoryWebApi.Models.Resources
{
    public class Esd : Resource
    {
        public Esd() { }
        public Esd(EsdEntity entity)
        {
            this.Id = entity.Id;
            this.Name = entity.Name;
            this.Code = entity.Code;
            this.AddressLine1 = entity.AddressLine1;
            this.AddressLine2 = entity.AddressLine2;
            this.State = entity.State;
            this.AdministratorName = entity.AdministratorName;
            this.Phone = entity.Phone;
            this.Email = entity.Email;
            this.ZipCode = entity.ZipCode;
        }
        public string AdministratorName { get; set; }
    }
}
