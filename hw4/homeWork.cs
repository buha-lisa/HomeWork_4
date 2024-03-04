namespace hw4
{
    internal class homeWork
    {
        public static void Task1()
        {
            Console.WriteLine("Choose the option:\n1.From binary to decimal\n2.From decimal to binary");
            Console.Write("Your choice: ");
            int.TryParse(Console.ReadLine(), out int choice);
            if (choice == 1)
            {
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
                    Console.WriteLine(res);
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
