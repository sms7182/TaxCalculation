using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxCalculation.Domain;
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
       
            var companies=repository.AllCompanies.Where(d => d.CompanyType == companyType).ToList();
            decimal sumTax = 0;
            for(var i = 0; i < companies.Count; i++)
            {
               sumTax+= CalculateTax(companies[i]);
            }
            return sumTax;
        }
        
        public decimal Calculate(string name){
            var company = repository.GetCompany(name);
            if(company==null){
                throw new ArgumentNullException("There is no Company with input name");
            }
            var result = CalculateTax(company);
            return result;
        }
        public decimal Calculate(int siret){
            var company = repository.GetCompany(siret);
            if(company==null){
                throw new ArgumentNullException("There is no Company with input siret");
            }
            var result = CalculateTax(company);
            return result;
        }
        private decimal CalculateTax(Company company)
        {
           
            var calculationOperation= calculateOperations.FirstOrDefault(it => it.Type == company.CompanyType);
           
            var sumTax= calculationOperation.Calculate(company.Turnover);
           
            return sumTax;
        }
    }
}
