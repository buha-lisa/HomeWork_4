namespace hw4
{
    internal class Task1
    {
        public static void Calculator()
        {
            Console.WriteLine("Choose the option:\n1.From binary to decimal\n2.From decimal to binary");
            Console.Write("Your choice: ");
            int.TryParse(Console.ReadLine(), out int choice);
            if (choice == 1)
            {
                Console.WriteLine("Enter a binary number:");
                string str = Console.ReadLine();
                int res = 0;
                try
                {
                    if (str.Length > int.MaxValue)
                    {
                        throw new Exception("Error..");
                    }
                    int exponent = 1;
                    for (int i = str.Length - 1; i >= 0; i--)
                    {
                        if (str[i] == '1')
                        {
                            res += exponent;
                        }
                        exponent *= 2;
                    }
                    Console.WriteLine($"Result: {res}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("End...");
                }
            }
            if (choice == 2)
            {
                Console.WriteLine("Enter a decimal number:");
                string str = Console.ReadLine();
                try
                {
                    int decimalNum = int.Parse(str);
                    if (str.Length > int.MaxValue)
                    {
                        throw new Exception("Error..");
                    }
                    string binaryNumber = string.Empty;
                    while (decimalNum > 0)
                    {
                        binaryNumber = (decimalNum % 2) + binaryNumber;
                        decimalNum /= 2;
                    }
                    Console.WriteLine($"Result: {binaryNumber}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("End...");
                }
            }
        }
    }
}
