using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TaxCalculation.Domain.Enums;
namespace TaxCalculation.Domain
{
    public class SAS:Company
    {
        public SAS()
        {
            CompanyType = CompanyType.SAS;
        }

        public string HeadOfficeAddress { get; set; }
    }
}
