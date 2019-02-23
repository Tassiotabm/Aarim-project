using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aarim.Models;
using Aarim.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Aarim.Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardController : Controller
    {
        private readonly ICreditCardService _creditService;

        public CreditCardController(ICreditCardService creditService)
        {
            _creditService = creditService;
        }

        // POST api/values
        [HttpPost]
        public async Task PostAsync([FromBody] CreditCard newCard)
        {
            try
            {
                await _creditService.CreateCreditCard(newCard);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
