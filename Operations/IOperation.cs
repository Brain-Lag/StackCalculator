namespace StackCalculator
{
    internal interface IOperation
    {

        public void Execute(Stack<double> stack, Dictionary<char, double> variables);
    }
}
