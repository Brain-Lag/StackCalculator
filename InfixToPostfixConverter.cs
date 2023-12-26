using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    internal class InfixToPostfixConverter
    {
        private static int GetPrecedence(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '@':
                case '$':
                    return 3;
                default:
                    return 0;
            }
        }
        public static string ConvertToPostfix(string infixExpression)
        {
            StringBuilder postfix = new StringBuilder();
            Stack<char> operatorStack = new Stack<char>();
            bool isPreviousTokenNumber = false;

            foreach (char token in infixExpression) 
            {
                if (char.IsDigit(token) || char.IsLetter(token))
                {
                    postfix.Append(token);
                    isPreviousTokenNumber = true;
                }
                else if (token == '(')
                {
                    if (isPreviousTokenNumber)
                    {
                        postfix.Append(' ');
                    }
                    operatorStack.Push(token);
                    isPreviousTokenNumber = false;
                }
                else if (token == ')')
                {
                    while (operatorStack.Count > 0 && operatorStack.Peek() != '(')
                    {
                        postfix.Append(' ');
                        postfix.Append(operatorStack.Pop());
                    }
                    if (operatorStack.Count > 0 && operatorStack.Peek() == '(') operatorStack.Pop();
                    isPreviousTokenNumber = false;
                }
                else
                {
                    if (isPreviousTokenNumber) postfix.Append(' ');

                    while (operatorStack.Count > 0 && GetPrecedence(operatorStack.Peek()) >= GetPrecedence(token))
                    {
                        postfix.Append(operatorStack.Pop());
                        postfix.Append(' ');
                    }
                    operatorStack.Push(token);
                    isPreviousTokenNumber = false;
                }
            }
            while (operatorStack.Count > 0)
            {
                postfix.Append(' ');
                postfix.Append(operatorStack.Pop());
            }
            return postfix.ToString().Trim();
        }
    }
}
