using StackCalculator.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    internal class SquareRoot : IOperation
    {
        public void Execute(Stack<double> stack)
        {
            if (stack.Count < 1) throw new OperandsAmountException("Недостаточно операндов для вычисления квадратного корня.");
            double operand1 = stack.Pop();
            stack.Push(Math.Sqrt(operand1));
        }

    }
}
