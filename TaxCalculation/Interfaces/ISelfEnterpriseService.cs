using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxCalculation.Domain;

namespace TaxCalculation.Interfaces
{
    public interface ISelfEnterpriseService
    {
        void AddSelfEnterprise(SelfEnterprise selfEnterprise);
    }
}
