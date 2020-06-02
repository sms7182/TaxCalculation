using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxCalculation.Domain.Enums;
using TaxCalculation.Interfaces;

namespace TaxCalculation.Services
{
    public class SelfCalculateOperation : ICalculateOperation
    {
        public CompanyType Type { get { return CompanyType.SelfEnterprise; } }

        public decimal Calculate(decimal turnover)
        {
            return (25 * turnover) / 100;
        }
    }
}
