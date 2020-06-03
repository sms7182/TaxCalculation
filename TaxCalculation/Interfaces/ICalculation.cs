using TaxCalculation.Domain.Enums;

namespace TaxCalculation.Interfaces
{
    public interface ICalculation
    {
        decimal Calculate(CompanyType companyType);
        decimal Calculate(int siret);
        decimal Calculate(string name);
    }
}
