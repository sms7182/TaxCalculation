using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
    }
}