using Microsoft.AspNetCore.Mvc;
using TaxCalculation.Domain;
using TaxCalculation.Interfaces;

namespace TaxCalculation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {

        ISelfEnterpriseService selfEnterpriseService;
        ISASService sASService;
        public CompanyController(ISelfEnterpriseService _selfEnterpriseService,ISASService _sAsService)
        {
            selfEnterpriseService = _selfEnterpriseService;
            sASService = _sAsService;
        }

        [HttpPost("addSelf")]
        public IActionResult AddSelf(SelfEnterprise selfEnterprise)
        {
            selfEnterpriseService.AddSelfEnterprise(selfEnterprise);
            return Ok();
        }
        
        [HttpPost("addSAS")]
        public IActionResult AddSAS(SAS sas)
        {
            sASService.AddSAS(sas);
            return Ok();
        }

    }
}