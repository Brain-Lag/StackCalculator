using StackCalculator.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    internal class Multiplication : IOperation
    {
        public void Execute(Stack<double> stack)
        {
            if (stack.Count < 2) throw new OperandsAmountException("Недостаточно операндов для умножения");
            double operand2 = stack.Pop();
            double operand1 = stack.Pop();
            stack.Push(operand1 * operand2);
        }
    }
}
