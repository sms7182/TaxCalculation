using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxCalculation.Domain;
using TaxCalculation.Interfaces;

namespace TaxCalculation.Services
{
    public class SelfEnterpriseService : ISelfEnterpriseService
    {
        IRepository repository;
        public SelfEnterpriseService(IRepository _repository)
        {
            repository = _repository;
        }
        public void AddSelfEnterprise(SelfEnterprise selfEnterprise)
        {
            repository.AddCompany(selfEnterprise);
        }
    }
}
