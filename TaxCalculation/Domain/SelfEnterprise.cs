using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TaxCalculation.Domain.Enums;
namespace TaxCalculation.Domain
{
    public class SelfEnterprise:Company
    {
        public SelfEnterprise()
        {
            CompanyType = CompanyType.SAS;
        }
    }
}
