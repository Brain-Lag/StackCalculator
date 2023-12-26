using StackCalculator.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    internal class Sinus : IOperation
    {
        public void Execute(Stack<double> stack)
        {
            if (stack.Count < 1) throw new OperandsAmountException("Недостаточно операндов для вычисления синуса.");
            double operand1 = stack.Pop();
            stack.Push(Math.Sin(operand1));
        }
    }
}
