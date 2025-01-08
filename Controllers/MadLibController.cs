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
    public class MadLibController : ControllerBase
    {

        private readonly MadLibService _madLibService;

        public MadLibController(MadLibService madLibService)
        {
            _madLibService = madLibService;
        }

        [HttpGet]
        [Route("MadLib/{Object}/{holiday}/{place}/{relative}/{animal}/{food}/{color}/{pluralNoun}/{adjective}/{weather}")]
        public string MadLib(string Object, string holiday, string place, string relative, string animal, string food, string color, string pluralNoun, string adjective, string weather )
        {

            return _madLibService.MadLib( Object,  holiday,  place,  relative,  animal,  food,  color,  pluralNoun,  adjective,  weather);

        }
        
    }
}