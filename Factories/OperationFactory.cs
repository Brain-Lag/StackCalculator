using StackCalculator.Exceptions;
using StackCalculator.Operations;

namespace StackCalculator.Factories
{
    internal class OperationFactory
    {
        public IOperation CreateOperation(string token)
        {
            if (double.TryParse(token, out double number))
            {
                return new Number(number);
            }
            else
            {
                switch (token)
                {
                    case "+":
                        return new Addition();
                    case "-":
                        return new Substraction();
                    case "*":
                        return new Multiplication();
                    case "/":
                        return new Division();
                    case "$":
                        return new Sinus();
                    case "@":
                        return new SquareRoot();
                    default:
                        throw new CalculatorException($"Неизвестная операция или некорректное число: {token}");
                }
            }
        }
    }
}
