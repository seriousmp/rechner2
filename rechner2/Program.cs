using System.Security.Cryptography.X509Certificates;

namespace rechner2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taschenrechner");
            Console.WriteLine("1. addition");
            Console.WriteLine("2. subtraktion");
            Console.WriteLine("3. multiplikation");
            Console.WriteLine("4. division");
            Console.WriteLine("5. Programm beenden");
            Console.WriteLine();
            Console.Write("Deine Auswahl: ");

            var eingabe = Console.ReadLine();

            Console.Clear();

            if (eingabe == "1")
            {
                Console.WriteLine("Addition");
                Console.WriteLine("Bitte ersten Sumand eingeben: ");
                var sumand1 = Console.ReadLine();

                Console.Clear();

                Console.WriteLine("Bitte zweiten Sumand eingeben: ");

                var sumand2 = Console.ReadLine();

                var zahl1 = int.Parse(sumand1);
                var zahl2 = int.Parse(sumand2);
                var summe = zahl1 + zahl2;

                Console.WriteLine("Summe: {0}", summe);


            }

            if (eingabe == "2")
            {
                Console.WriteLine("Subtraktion");
                Console.WriteLine("Bitte ersten Minuend eingeben");

                var minuend = Console.ReadLine();

                Console.Clear();

                Console.WriteLine("Bitte den Subtrahend eingeben");

                var subtrahend = Console.ReadLine();

                var zahl3 = int.Parse(minuend);
                var zahl4 = int.Parse(subtrahend);
                var differenz = zahl3 - zahl4;

                Console.WriteLine("Differenz: {0}", differenz);
            }

            if (eingabe == "3")
            {
                Console.WriteLine("multiplikation");
                Console.WriteLine("Bitte den ersten Faktor eingeben");

                var faktor = Console.ReadLine();

                Console.WriteLine("Bitte den zweiten Faktor eingeben");

                var faktor2 = Console.ReadLine();

                var zahl5 = int.Parse(faktor);
                var zahl6 = int.Parse(faktor2);
                var produkt = zahl5 * zahl6;

                Console.WriteLine("Produkt: {0}", produkt);
            }
            {
                if (eingabe == "4")
                {
                    Console.WriteLine("Division");
                    Console.WriteLine("Bitte den Dividend eingeben");

                    var dividend = Console.ReadLine();

                    Console.Clear();

                    Console.WriteLine("Bitte den Divisor eingeben");

                    var divisor = Console.ReadLine();

                    var zahl7 = int.Parse(dividend);
                    var zahl8 = int.Parse(divisor);
                    var quotient = zahl7 / zahl8;

                    Console.WriteLine("Quotient: {0}", quotient);
                }
            }
        }
    }
}

    



        
        
    
        
    


        
