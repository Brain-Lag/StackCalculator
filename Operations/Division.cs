using StackCalculator.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    internal class Division : IOperation
    {
        public void Execute(Stack<double> stack, Dictionary<char, double> variables)
        {
            if (stack.Count < 2) throw new OperandsAmountException("Недостаточно операндов для деления");
            double operand2 = stack.Pop();
            double operand1 = stack.Pop();
            if (operand1 == 0) throw new DivideByZeroException("Попытка деления на ноль");
            stack.Push(operand1 / operand2);
        }
    }
}
