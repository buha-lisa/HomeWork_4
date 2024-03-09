namespace hw4
{
    internal class Task2
    {
        public static void ConvertWordInNumber()
        {
            Console.Write("Enter number in word: ");
            string number = Console.ReadLine();
            try
            {
                if (number.Length > int.MaxValue)
                {
                    throw new Exception("Error..");
                }
                int res = WordToNumber(number);
                Console.WriteLine(res);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("End...");
            }
        }
        public static int WordToNumber(string number)
        {
            switch (number)
            {
                case "zero":
                    return 0;
                case "one":
                    return 1;
                case "two":
                    return 2;
                case "three":
                    return 3;
                case "four":
                    return 4;
                case "five":
                    return 5;
                case "six":
                    return 6;
                case "seven":
                    return 7;
                case "eight":
                    return 8;
                case "nine":
                    return 9;
                default:
                    return -1;
            }
        }
    }
}
