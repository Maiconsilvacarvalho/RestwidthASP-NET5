using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestWithASPNET5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
      
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }
        //Adição

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
       

        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))

            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
               

                return Ok(sum.ToString());

                
            }
            return BadRequest("Invalid Input");
        }

        //Subtração
        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]


        public IActionResult Subtraction(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))

            {
                var sum = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);


                return Ok(sum.ToString());


            }
            return BadRequest("Invalid Input");
        }


        //raiz quadradada
        [HttpGet("squareroot/{firstNumber}")]


        public IActionResult Squareroot(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) )

            {
                var squareroot = Math.Sqrt((double)ConvertToDecimal(firstNumber));


                return Ok(squareroot.ToString());


            }
            return BadRequest("Invalid Input");
        }


        //Divisião

        [HttpGet("division/{firstNumber}/{secondNumber}")]


        public IActionResult Division(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))

            {
                var division = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);


                return Ok(division.ToString());


            }
            return BadRequest("Invalid Input");
        }

        //Multiplication

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]


        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))

            {
                var multipliation = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);


                return Ok(multipliation.ToString());


            }
            return BadRequest("Invalid Input");
        }


        private bool IsNumeric(string strNumber)
         {
            double number;
            bool isNumber = double.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number );
            return isNumber;
           
          }

         private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;

            if(decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;

            }
            return 0;
        }
    }
}
