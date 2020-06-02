using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxCalculation.Interfaces;

namespace TaxCalculation.Services
{
    public class CalculationFactory : ICalculationFactory
    {

        private readonly SASCalculateOperation sASCalculateOperation;
        private readonly SelfCalculateOperation selfCalculateOperation;
        public CalculationFactory(SASCalculateOperation _sASCalculateOperation,SelfCalculateOperation _selfCalculateOperation)
        {
            sASCalculateOperation = _sASCalculateOperation;
            selfCalculateOperation = _selfCalculateOperation;
        }
        public List<ICalculateOperation> GenerateCalculateOperation()
        {
          return  new List<ICalculateOperation>() { sASCalculateOperation,selfCalculateOperation};
        }
    }
}
