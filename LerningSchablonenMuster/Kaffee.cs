namespace LerningSchablonenMuster
{
    public class Kaffee : KaffeeSpezialitaet
    {
        protected override void BereiteMilchschaum()
        {
            return;
        }

        public override string ToString()
        {
            return "Kaffee";
        }
    }
}
