using StackCalculator.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    internal class Calculator
    {
        Stack<double> stack = new Stack<double>();
        Dictionary<char, double> variables = new Dictionary<char, double>();

        public double Calculate(string expression)
        {
            stack.Clear();
            string postfixExpression = InfixToPostfixConverter.ConvertToPostfix(expression);

            string[] tokens = postfixExpression.Split(' ');
            IOperationFactory factory = new OperationFactory();

            foreach (string token in tokens)
            {
                IOperation operation = factory.CreateOperation(token);
                try
                {
                    operation.Execute(stack, variables);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка выполнения операции: {ex.Message}");
                }
            }
            if (stack.Count == 1) return stack.Pop();
            else throw new InvalidOperationException("Некорректное выражение");
        }
    }
}
