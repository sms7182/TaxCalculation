
using TaxCalculation.Domain.Enums;
namespace TaxCalculation.Domain
{
    public class SelfEnterprise:Company
    {
        public override CompanyType CompanyType => CompanyType.SelfEnterprise;
    }
}
