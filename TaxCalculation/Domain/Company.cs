using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxCalculation.Domain.Enums;

namespace TaxCalculation.Domain
{
    public abstract class Company
    {
        public int SIRET { get; set; }
        public string Name { get; set; }
        public CompanyType CompanyType { get; set; }
        public decimal Turnover { get; set; }
    }
}
