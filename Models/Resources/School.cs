using DirectoryWebApi.Models.Entities;

namespace DirectoryWebApi.Models.Resources
{
    public class School : Resource
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
        public School(SchoolEntity entity)
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

            this.PrincipalName = entity.PrincipalName;
            this.City = entity.City;
            this.EsdCode = entity.EsdCode;
            this.EsdName = entity.EsdName;
            this.LeaCode = entity.LeaCode;
            this.LeaName = entity.LeaName;
            this.AypCode = entity.AypCode;
            this.GradeCategory = entity.GradeCategory;
            this.OrgCategoryList = entity.OrgCategoryList;
            this.HighestGrade = entity.HighestGrade;
            this.LowestGrade = entity.LowestGrade;
        }
        public School() { }
    }
}
