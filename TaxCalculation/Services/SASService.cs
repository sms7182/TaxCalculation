using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxCalculation.Domain;
using TaxCalculation.Interfaces;

namespace TaxCalculation.Services
{
    public class SASService : ISASService
    {
        IRepository repository;
        public SASService(IRepository _repository)
        {
            repository = _repository;
        }
        public void AddSAS(SAS sas)
        {
            repository.AddCompany(sas);
        }
    }
}
