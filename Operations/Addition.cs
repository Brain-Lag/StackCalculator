using StackCalculator.Exceptions;

namespace StackCalculator
{
    internal class Addition : IOperation
    {
        public void Execute(Stack<double> stack)
        {
            if (stack.Count < 2) throw new OperandsAmountException("Недостаточно операндов для сложения.");
            double operand2 = stack.Pop();
            double operand1 = stack.Pop();
            stack.Push(operand1 + operand2);
        }
    }
}
