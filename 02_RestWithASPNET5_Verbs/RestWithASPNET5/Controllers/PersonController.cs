﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestWithASPNET5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
      
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }
        //Adição

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
       

        public IActionResult Sum(string firstNumber, string secondNumber)
        {
           
            return BadRequest("Invalid Input");
        }

        
        }
    }
}
