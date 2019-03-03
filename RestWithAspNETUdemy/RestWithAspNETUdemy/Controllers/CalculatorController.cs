using Microsoft.AspNetCore.Mvc;

namespace RestWithAspNETUdemy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : Controller
    {
        
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var result = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(result.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var result = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(result.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("multiplication/{number}/{multiplicationNumber}")]
        public IActionResult Multiplication(string number, string multiplicationNumber)
        {
            if (IsNumeric(number) && IsNumeric(multiplicationNumber))
            {
                var result = ConvertToDecimal(number) * ConvertToDecimal(multiplicationNumber);
                return Ok(result.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("division/{number}/{divisionNumber}")]
        public IActionResult Division(string number, string divisionNumber)
        {
            if (IsNumeric(number) && IsNumeric(divisionNumber))
            {
                if (ConvertToDecimal(divisionNumber) <= 0)
                {
                    return BadRequest("Division by zero is not allowed");
                }

                var result = ConvertToDecimal(number) / ConvertToDecimal(divisionNumber);
                return Ok(result.ToString());
            }

            return BadRequest("Invalid Input");
        }

        private decimal ConvertToDecimal(string number)
        {
            decimal decimalValue;

            if (decimal.TryParse(number, out decimalValue))
            {
                return decimalValue;
            }

            return 0;
        }

        private bool IsNumeric(string strnumber)
        {
            double number;
            return double.TryParse(strnumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
        }
    }
}