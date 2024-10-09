using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class CalculatorController : ControllerBase
{
    private readonly ICalculatorService _calculatorService;

    public CalculatorController(ICalculatorService calculatorService)
    {
        _calculatorService = calculatorService;
    }

    [HttpGet("PerformAddition")]
    public ActionResult<int> Add(int a, int b)
    {
        return Ok(_calculatorService.Add(a, b));
    }

    [HttpGet("PerformSubtraction")]
    public ActionResult<int> Subtract(int a, int b)
    {
        return Ok(_calculatorService.Subtract(a, b));
    }

    [HttpGet("PerformMultiplication")]
    public ActionResult<int> Multiply(int a, int b)
    {
        return Ok(_calculatorService.Multiply(a, b));
    }

    [HttpGet("PerformDivision")]
    public ActionResult<int> Divide(int a, int b)
    {
        try
        {
            return Ok(_calculatorService.Divide(a, b));
        }
        catch (DivideByZeroException)
        {
            return BadRequest("Cannot divide by zero.");
        }
    }
}

