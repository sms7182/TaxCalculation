using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxCalculation.Domain;
using TaxCalculation.Interfaces;

namespace TaxCalculation.Repositories
{
    public class Repository : IRepository
    {
        public List<Company> AllCompanies { get; set; }

        public Repository()
        {
            AllCompanies = new List<Company>();
        }
        public void AddCompany(Company company)
        {
            AllCompanies.Add(company);
        }
    }
}
