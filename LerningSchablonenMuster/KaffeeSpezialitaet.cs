using System;
using System.Threading;

namespace LerningSchablonenMuster
{
    public abstract class KaffeeSpezialitaet
    {
        public enum Spezialität
        {
            Kaffee = 1,
            SchaumKaffee,
            Espresso
        }

        public void BereiteZu()
        {
            MahleBohnen();
            Console.WriteLine("Wasser wird aufgekocht\n");
            BereiteMilchschaum();
            BrueheKaffee();
            Console.WriteLine("Trester wird entworgt\n");
            ReinigeMaschine();
            Beenden();
        }

        private void Beenden()
        {
            Console.WriteLine("Kaffee kochen ist abgeschlossen.\n");
            Thread.Sleep(1000);
            Console.WriteLine("Press key Zum Zurückkehren\n");
            Console.ReadKey();
            Console.Clear();
        }

        private void ReinigeMaschine()
        {
            string arbeitsGang = "Einen Moment Maschine wird gereinigt...";
            string abgeschlossen = "Maschine wurde Gereinigt";
            int bearbeitungszeit = 2000;

            Zubereitung(arbeitsGang, abgeschlossen,bearbeitungszeit); 
        }

        private void BrueheKaffee()
        {
            string arbeitsGang = "Einen Moment Kaffee wird gebrüht..";
            string abgeschlossen = "Kaffee wurde gebrüht";
            int bearbeitungszeit = 5000;

            Zubereitung(arbeitsGang, abgeschlossen,bearbeitungszeit);
        }

        protected virtual void BereiteMilchschaum()
        {
            string arbeitsGang = "Milchschaum wird zubereitet einen Moment...";
            string abgeschlossen = "Milchschaum wurde bereitet";

            Zubereitung(arbeitsGang, abgeschlossen,1500);
        }

        private void MahleBohnen()
        {
            string arbeitsGang = "Einen Moment Bohnen werden gemahlt...";
            string abgeschlossen = "Bohnen wurden fertig gemahlt";

            Zubereitung(arbeitsGang, abgeschlossen,500);
        }

        private void Zubereitung(string arbeit,string fertig,int arbeitszeit)
        {
            Console.WriteLine(arbeit);
            Thread.Sleep(arbeitszeit);
            Console.WriteLine(fertig);
            Console.WriteLine();
        }
    }
}
