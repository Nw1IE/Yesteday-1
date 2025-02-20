namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Произведния: " + Metod.Met(12, 7));
            Console.WriteLine("Произведния: " + Metod.Met(411, 8));
            Console.WriteLine("Произведния: " + Metod.Met(242423432, 4234));
            Console.WriteLine("Произведния: " + Metod.Met(24.4, 4.53) + "\n");

            Student bob = new Student("Bob Peter Anderson", 3.5, 5, "15.07,2024");
            Student sue = new Student("Sue Augustina Lourenzzo", 5, 3, "21.07,2024");
            Student victor = new Student("Victor Petrovith Diakonov", 5, 5, "30.07,2024\n");

            Console.WriteLine($"Боб круче Сью? {bob > sue}");
            Console.WriteLine($"Виктор круче Сью? {victor > sue}");
            Console.WriteLine($"Боб круче Виктора? {bob > victor}\n");

            Console.WriteLine($"Проходит ли Боб?  {Admission.IsPass(bob)}");
            Console.WriteLine($"Проходит ли Виктор?  {Admission.IsPass(victor)}");
            Console.WriteLine($"Проходит ли Сью?  {Admission.IsPass(sue)}\n");

            Console.WriteLine($"Ставка по проценту = {Deposit.PercentSum} ");
        }
    }
}