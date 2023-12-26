using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator.Operations
{
    internal class Number : IOperation
    {
        private double _value;

        public Number(double value)
        {
            this._value = value;
        }

        public void Execute(Stack<double> stack)
        {
            stack.Push(_value);
        }
    }
}
