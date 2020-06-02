using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxCalculation.Domain.Enums;

namespace TaxCalculation.Interfaces
{
    public interface ICalculateOperation
    {
         CompanyType Type { get;  }
         decimal Calculate(decimal turnover);
    }
}
