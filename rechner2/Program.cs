using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace rechner2
{
    internal class Program
    {
        private static int zahl8;

        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen zum Taschenrechner!");
            Console.WriteLine("Heute ist: " + DateTime.Now.ToString("dd.MM.yyyy"));
            Console.WriteLine("Uhrzeit: " + DateTime.Now.ToString("HH:mm"));
      
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

                if (!double.TryParse(sumand1, out double zahl1))
                {
                    Console.WriteLine("Ungültige Eingabe.");
                    return;
                }

                Console.Clear();

                Console.WriteLine("Bitte zweiten Sumand eingeben: ");

                var sumand2 = Console.ReadLine();

                if (!double.TryParse(sumand2, out double zahl2))

                {
                    Console.WriteLine("Ungültige Eingabe.");
                    return;
                }
                var summe = zahl1 + zahl2;

                Console.WriteLine("Summe: {0}", summe);


            }

            if (eingabe == "2")
            {
                Console.WriteLine("Subtraktion");
                Console.WriteLine("Bitte ersten Minuend eingeben");

                var minuend = Console.ReadLine();

                if (!double.TryParse(minuend, out double zahl4))
                {
                    Console.WriteLine("Ungültige Eingabe.");
                    return;
                }

                Console.Clear();

                Console.WriteLine("Bitte den Subtrahend eingeben");

                var subtrahend = Console.ReadLine();

                if (!double.TryParse(subtrahend, out double zahl3))
                {
                    Console.WriteLine("Ungültige Eingabe.");
                    return;
                }

                var differenz = zahl4 - zahl3;

                Console.WriteLine("Differenz: {0}", differenz);
            }

            if (eingabe == "3")
            {
                Console.WriteLine("multiplikation");
                Console.WriteLine("Bitte den ersten Faktor eingeben");

                var faktor = Console.ReadLine();

                if (!double.TryParse(faktor, out double zahl5))
                {
                    Console.WriteLine("Ungültige Eingabe.");
                    return;
                }

                Console.WriteLine("Bitte den zweiten Faktor eingeben");

                var faktor2 = Console.ReadLine();

                if (!double.TryParse(faktor2, out double zahl6))
                {
                    Console.WriteLine("Ungültige Eingabe.");
                    return;
                }

                var produkt = zahl5 * zahl6;

                Console.WriteLine("Produkt: {0}", produkt);
            }
            {
                if (eingabe == "4")
                {
                    Console.WriteLine("Division");
                    Console.WriteLine("Bitte den Dividend eingeben");

                    var dividend = Console.ReadLine();

                    if (!double.TryParse(dividend, out double zahl7))
                    {
                        Console.WriteLine("Ungültige Eingabe.");
                        return;
                    }
                    Console.Clear();


                    Console.WriteLine("Bitte den Divisor eingeben");

                    var divisor = Console.ReadLine();



                    if (!double.TryParse(divisor, out double zahl8))

                    {
                        Console.WriteLine("Ungültige Eingabe.");

                        return;
                        
                    }

                    if (zahl8 == 0)
                    {
                        Console.WriteLine("Division durch 0 ist nicht erlaubt");

                    }
                    else
                    {

                        var quotient = zahl7 / zahl8;

                        Console.WriteLine("Quotient: {0}", quotient);
                    }
                }
            }
        }
    }
}



    



        
        
    
        
    


        
