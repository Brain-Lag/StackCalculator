namespace StackCalculator
{
    class Program
    {
        public static void Main()
        {
            Calculator calculator = new Calculator();
            double result;
            string infixExpression;
            while (true)
            {
                Console.WriteLine("Введите арифметическое выражение:");
                infixExpression = Console.ReadLine();

                try
                {
                    result = calculator.Calculate(infixExpression);
                    Console.WriteLine($"Результат: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }

        }
    }
}