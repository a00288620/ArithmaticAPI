public class simplemathservice : ICalculatorService
{
    public int Add(int firstnumber, int secondnumber) => firstnumber + secondnumber;

    public int Subtract(int firstnumber, int secondnumber) => firstnumber - secondnumber;

    public int Multiply(int firstnumber, int secondnumber) => firstnumber * secondnumber;

    public int Divide(int firstnumber, int secondnumber)
    {
        if (secondnumber == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
        return firstnumber / secondnumber;
    }
}
