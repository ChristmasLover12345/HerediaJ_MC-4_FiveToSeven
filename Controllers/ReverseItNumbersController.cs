using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HerediaJ_MC_4_FiveToSeven.Services;
using Microsoft.AspNetCore.Mvc;

namespace HerediaJ_MC_4_FiveToSeven.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItNumbersController : ControllerBase
    {
        
        private readonly ReverseItNumbersService _reverseItNumbersService;

        public ReverseItNumbersController(ReverseItNumbersService reverseItNumbersService)
        {
            _reverseItNumbersService = reverseItNumbersService;
        }


        [HttpGet]
        [Route("ReverseNumber/{number}")]
        public string ReverseNumbers(string number)
        {
            return _reverseItNumbersService.ReverseNumbers(number);
        }

    }
}