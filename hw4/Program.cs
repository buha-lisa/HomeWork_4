namespace hw4
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Choose number of task(1-4): ");
                int.TryParse(Console.ReadLine(), out int task);
                switch (task)
                {
                    case 1:
                        Task1.Calculator();
                        break;
                    case 2:
                        Task2.ConvertWordInNumber();
                        break;
                    case 3:
                        Console.WriteLine("Enter passport number:");
                        string numberPassport = Console.ReadLine();
                        Console.WriteLine("Enter full name:");
                        string name = Console.ReadLine(); 
                        Console.WriteLine("Enter date of issue:");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        Task3ForeignPassport passport = new Task3ForeignPassport(numberPassport, name, date);
                        passport.ShowInfo();
                        break;
                    case 4:
                        Task4.Expression();
                        break;
                }
                if (task == 0) break;
            }
        }
    }
}
