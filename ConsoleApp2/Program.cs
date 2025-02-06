namespace ConsoleApp2
{
    internal class Program

        static void Main(string[] args)
        {
            //Begint hier
            //plus, min, delen door en bonus: Modulo
            //een instance maken van de calculator
            Calculator mijnCalculator = new Calculator();
            int antwoord = mijnCalculator.Plus(10, 3);
            int antwoord1 = mijnCalculator.Min(10, 3);
            int antwoord2 = mijnCalculator.Div(10, 3);
            int antwoord3 = mijnCalculator.Mult(10, 3);
            int antwoord4 = 100;
            Console.WriteLine(antwoord);
            Console.WriteLine(antwoord1);
            Console.WriteLine(antwoord2);
            Console.WriteLine(antwoord3);
            
            Console.WriteLine(antwoord4);

            //maak een output van 0 t/m 100
            for (int i = 0; i <= antwoord4; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("XD");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
}

/* 
 QUIZ-OPDRACHTEN LES

 Hoe herken je een functie?
 - het staat binnen de haakjes '()' en bevat een scope '{}'

 Hoe herken je een varabele?
 - het heeft geen haakjes of scope

 Hoe zou je omschrijven wat een class is?
 - een soort van blueprint die je ten alle tijden kan gebruiken
 */
