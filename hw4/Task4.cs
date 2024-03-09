namespace hw4
{
    internal class Task4
    {
        public static void Expression()
        {
            Console.WriteLine("Enter a logical expression:");
            string expression = Console.ReadLine();

            try
            {
                bool result = EvaluateLogicalExpression(expression);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static bool EvaluateLogicalExpression(string expression)
        {
            string[] parts = expression.Split(new[] { '<', '>', '=', '!' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 2)
            {
                throw new Exception("Invalid expression format.");
            }

            int leftOperand = int.Parse(parts[0]);
            int rightOperand = int.Parse(parts[1]);

            if (expression.Contains("<"))
            {
                return leftOperand < rightOperand;
            }
            else if (expression.Contains(">"))
            {
                return leftOperand > rightOperand;
            }
            else if (expression.Contains("<="))
            {
                return leftOperand <= rightOperand;
            }
            else if (expression.Contains(">="))
            {
                return leftOperand >= rightOperand;
            }
            else if (expression.Contains("=="))
            {
                return leftOperand == rightOperand;
            }
            else if (expression.Contains("!="))
            {
                return leftOperand != rightOperand;
            }
            else
            {
                throw new Exception("Invalid operator.");
            }
        }
    }
}
