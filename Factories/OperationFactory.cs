using StackCalculator.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator.Factories
{
    internal class OperationFactory : IOperationFactory
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
                    default:
                        throw new InvalidOperationException($"Неизвестная операция или некорректное число: {token}");
                }
            }
        }
    }
}
