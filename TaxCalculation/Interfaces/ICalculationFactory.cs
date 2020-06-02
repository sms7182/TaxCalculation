using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxCalculation.Interfaces
{
    public interface ICalculationFactory
    {
        List<ICalculateOperation> GenerateCalculateOperation();
    }
}
