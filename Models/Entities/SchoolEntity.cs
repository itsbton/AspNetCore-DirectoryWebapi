using DirectoryWebApi.Models.Resources;

namespace DirectoryWebApi.Models.Entities
{
    public class SchoolEntity : BaseEntity
    {
        public string PrincipalName { get; set; }
        public string LowestGrade { get; set; }
        public string HighestGrade { get; set; }
        public string AypCode { get; set; }
        public string City { get; set; }
        public string GradeCategory { get; set; }
        public string OrgCategoryList { get; set; }
        public string EsdCode { get; set; }
        public string EsdName { get; set; }
        public string LeaCode { get; set; }
        public string LeaName { get; set; }
        public SchoolEntity(School resource)
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

            this.PrincipalName = resource.PrincipalName;
            this.City = resource.City;
            this.EsdCode = resource.EsdCode;
            this.EsdName = resource.EsdName;
            this.LeaCode = resource.LeaCode;
            this.LeaName = resource.LeaName;
            this.AypCode = resource.AypCode;
            this.GradeCategory = resource.GradeCategory;
            this.OrgCategoryList = resource.OrgCategoryList;
            this.HighestGrade = resource.HighestGrade;
            this.LowestGrade = resource.LowestGrade;
        }
        public SchoolEntity() { }
    }
}
