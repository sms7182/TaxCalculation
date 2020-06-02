using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxCalculation.Domain.Enums;
using TaxCalculation.Interfaces;

namespace TaxCalculation.Services
{
    public class Calculation : ICalculation
    {
        private readonly List<ICalculateOperation> calculateOperations;

        IRepository repository;
        public Calculation(List<ICalculateOperation> _calculateOperations,IRepository _repository)
        {
            calculateOperations = _calculateOperations;
            repository = _repository;
        }
        public decimal Calculate(CompanyType companyType)
        {
           var calculationOperation= calculateOperations.FirstOrDefault(it => it.Type == companyType);
            var companies=repository.AllCompanies.Where(d => d.CompanyType == companyType).ToList();
            decimal sumTax = 0;
            for(var i = 0; i < companies.Count; i++)
            {
               sumTax+= calculationOperation.Calculate(companies[i].Turnover);
            }
            return sumTax;
        }
    }
}
