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
    public class ReverseItAplhaController : ControllerBase
    {
        
        private readonly ReverseItAplhaService _reverseItAplhaService;

        public ReverseItAplhaController(ReverseItAplhaService reverseItAplhaService)
        {
            _reverseItAplhaService = reverseItAplhaService;
        }


        [HttpGet]
        [Route("ReverseAlpha/{word}")]
        public string ReverseAlpha(string word)
        {
            return _reverseItAplhaService.ReverseAlpha(word);
        }

    }
}