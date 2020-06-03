using Microsoft.AspNetCore.Mvc;
using TaxCalculation.Domain.Enums;
using TaxCalculation.Interfaces;

namespace TaxCalculation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        private readonly ICalculation calculation;

        public CalculateController(ICalculation _calculation)
        {
            calculation = _calculation;
        }


        [HttpGet]
        public IActionResult CalculateTaxOf(int companyType)
        {
            return Ok(calculation.Calculate((CompanyType)companyType));
        }

        [HttpGet("CalculateByName")]
        public IActionResult CalculateTaxOfName(string companyName)
        {
            return Ok(calculation.Calculate(companyName));
        }

        [HttpGet("CalculateBySIRET")]
        public IActionResult CalculateTaxOfSIRET(int companySIRET)
        {
            return Ok(calculation.Calculate(companySIRET));
        }
    }
}