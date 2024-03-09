namespace hw4
{
    class Task3ForeignPassport
    {
        public string PassportNumber { get; set; }
        public string OwnerName { get; set; }
        public DateTime DateOfIssue { get; set; }
        public Task3ForeignPassport(string number, string name, DateTime date)
        {

            PassportNumber = number;
            OwnerName = name;
            DateOfIssue = date;
        }
        public void ShowInfo()
        {
            try
            {
                if (PassportNumber == "" || OwnerName == "" || DateOfIssue > DateTime.Now)
                {
                    throw new Exception("Error..");
                }
                Console.WriteLine($"Number:\n{PassportNumber}");
                Console.WriteLine($"Name:\n{OwnerName}");
                Console.WriteLine($"Date:\n{DateOfIssue}");
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
