
using TaxCalculation.Domain.Enums;
namespace TaxCalculation.Domain
{
    public class SAS:Company
    {      
        public string HeadOfficeAddress { get; set; }

        public override CompanyType CompanyType => CompanyType.SAS;
       
    }
}
