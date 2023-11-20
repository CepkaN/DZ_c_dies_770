namespace DZ_c_dies_770
{

    internal class Program
    {
        
        static void Main(string[] args)
        {
            Money MMM = new Money(" рублей ", 2000, 12);
            MMM.Mostra();
            Product PRR = new Product(" Компьютер ", " рублей ", 60000, 50);
            PRR.Mo();
            PRR.PrixVar(1001);

            Bollitore bol=new Bollitore();
            Microonde micr=new Microonde();
            Auto auto=new Auto();
            Piroscafo pir=new Piroscafo();
            List<Apparato>LIST=new List<Apparato>() { bol, micr, auto, pir };
            foreach(var L in LIST)
            {
                L.Show();L.Desc();L.Sound();
            }

            Violino vio=new Violino();
            Trombone tromb=new Trombone();
            Ukulele uk=new Ukulele();
            Violoncello vice=new Violoncello();
            List<StrumentoMusicale> STRMUS = new List<StrumentoMusicale>() {vio,tromb,uk,vice };
            foreach (var L in STRMUS)
            {
                L.Show(); L.Desc(); L.Sound();L.History();
            }

            President pre=new President();
            Security sec=new Security();
            Manager man=new Manager();
            Engineer en=new Engineer();
            List<Worker>WOR=new List<Worker>() { pre,sec,man,en};
            foreach (var L in WOR)
            {
                L.Print();
            }

            CreditCard CRCARD = new CreditCard("123", 20000, 20, " рублей ");
            CRCARD.Summa();
            Money M=CRCARD + MMM;
            CRCARD.Summa();
        }
    }
}