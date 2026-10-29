namespace _15._10._26_homework_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t-------Task2----------");
            Numbers number = new Numbers();

            Console.WriteLine("Enter number is words:");
            string word = Console.ReadLine();

            number.PrintNumbers(word);

            Console.WriteLine("\n\t-------Task3----------");

            ForeignPassport passport = new ForeignPassport(
                "AB123456",
                "Ivan",
                "Petrenko",
                new DateTime(2026, 5, 10)
            );

            passport.ShowInfo();
        }
    }
}
