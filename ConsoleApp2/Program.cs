namespace ConsoleApp2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Calculator mijnCalculator = new Calculator();

            int antwoord = mijnCalculator.Plus(10, 3);
            Console.WriteLine(antwoord + "(Let niet op dit)");

            Console.WriteLine("Wie is de nieuwe user? (Naam + enter, leeftijd + enter, Address + enter)");
            User nieuw1 = new User(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            //supernetjes dit! Kijk misschien nog even naar de "Factory design pattern"
            Console.WriteLine("Deze user heet: " + nieuw1.name);
            Console.WriteLine("Deze user is: " + nieuw1.age + " jaar oud.");
            Console.WriteLine("Deze user's address is: " + nieuw1.address);
        }
    }
}
