using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using TaxCalculation.Interfaces;

namespace TaxCalculation.Services
{
    public class CalculationFactory : ICalculationFactory
    {

        public List<ICalculateOperation> GenerateCalculateOperation()
        {
            var types = this.GetType().Assembly.GetTypes()
                        .Where(it=>(typeof(ICalculateOperation)).IsAssignableFrom(it) && !it.IsInterface);
           var result = types
                        .Select(it=>Activator.CreateInstance(it))
                        .Cast<ICalculateOperation>().ToList();
                        return result;
       
        }
    }
}
