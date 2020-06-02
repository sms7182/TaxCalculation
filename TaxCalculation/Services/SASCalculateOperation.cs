using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxCalculation.Domain.Enums;
using TaxCalculation.Interfaces;

namespace TaxCalculation.Services
{
    public class SASCalculateOperation : ICalculateOperation
    {
        public CompanyType Type { get { return CompanyType.SAS; } }

        public decimal Calculate(decimal turnover)
        {
            return (33 * turnover) / 100;
        }
    }
}
