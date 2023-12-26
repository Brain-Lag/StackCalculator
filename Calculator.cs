using StackCalculator.Exceptions;
using StackCalculator.Factories;

namespace StackCalculator
{
    internal class Calculator
    {
        Stack<double> stack = new Stack<double>();

        public double Calculate(string expression)
        {
            stack.Clear();
            string postfixExpression = InfixToPostfixConverter.ConvertToPostfix(expression);

            string[] tokens = postfixExpression.Split(' ');
            OperationFactory factory = new OperationFactory();

            foreach (string token in tokens)
            {
                IOperation operation = factory.CreateOperation(token);
                try
                {
                    operation.Execute(stack);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка выполнения операции: {e.Message}");
                }
            }
            if (stack.Count == 1) return stack.Pop();
            else throw new CalculatorException("Некорректное выражение");
        }
    }
}
