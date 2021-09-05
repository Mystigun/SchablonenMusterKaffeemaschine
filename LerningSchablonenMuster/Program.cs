using System;

namespace LerningSchablonenMuster
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                WillkommenAusgabe();

                string eingabe = Console.ReadLine();

                AuswahlBenutzer(eingabe);                           
            }

            void WaehleKaffeeSpezialität()
            {
                Console.Clear();
                Console.WriteLine("Sie möchten einen Kaffee Zubreiten wählen Sie bitte eine Kaffeespezialität aus! ");
                Console.WriteLine("1 = Kaffee\n2 = SchaumKaffee\n3 = Espresso");

                string eingabe = Console.ReadLine();

                if(int.TryParse(eingabe,out int ausgabe))
                {
                    switch (ausgabe)
                    {
                        case (int)KaffeeSpezialitaet.Spezialität.Kaffee:
                            BereiteZu(new Kaffee());
                            break;

                        case (int)KaffeeSpezialitaet.Spezialität.SchaumKaffee:
                            BereiteZu(new SchaumKaffee());
                            break;

                        case (int)KaffeeSpezialitaet.Spezialität.Espresso:
                            BereiteZu(new Espresso());
                            break;
                        default:
                            Console.WriteLine("Auswahl nich vorhanden");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Falsche eingabe, abbruch Kaffeemaschine wird neugestartet!");
                    return;
                }

            }

            void BereiteZu(KaffeeSpezialitaet kaffeeSpezialitaet)
            {
                Console.WriteLine($"{kaffeeSpezialitaet} wird zubereitet!");
                kaffeeSpezialitaet.BereiteZu();
            }

            void WillkommenAusgabe()
            {
                Console.WriteLine("Willkomen zur Kaffemaschine");
                Console.WriteLine();
                Console.WriteLine("Möchten sie einen kaffee zu bereiten?\npress 1 für Ja\nPress 2 für Beenden");
            }

            void AuswahlBenutzer(string eingabe)
            {
                if (eingabe == "1")
                {
                    WaehleKaffeeSpezialität();
                }
                else if (eingabe == "2")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
