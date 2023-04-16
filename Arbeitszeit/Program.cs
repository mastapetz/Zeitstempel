namespace Arbeitszeit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ArbeitsZeitKlasse ZeitStempelEins = new(DateTime.Now.AddHours(-7), DateTime.Now);
            //Zeit._end = DateTime.Now;
            //Zeit._start = Zeit._end.AddHours(-7);

            //unter 6.5 stunden
            DateTime eingangStempel1 = DateTime.Parse("9:00");
            DateTime ausgangsStempel1 = DateTime.Parse("15:00");
            ArbeitsZeitKlasse StempelPaar1 = new(eingangStempel1, ausgangsStempel1);
            Console.WriteLine(StempelPaar1);
            //*******************
            Console.WriteLine("----------------------------------");
            //*******************
            //über 6.5 stunden
            DateTime eingangStempel2 = DateTime.Parse("9:00");
            DateTime ausgangsStempel2 = DateTime.Parse("19:00");
            ArbeitsZeitKlasse StempelPaar2 = new(eingangStempel2, ausgangsStempel2);
            Console.WriteLine(StempelPaar2);
            //*******************
            Console.WriteLine("----------------------------------");
            //*******************
            //falsche Zeit
            DateTime eingangStempel3 = DateTime.Parse("11:00");
            DateTime ausgangsStempel3 = DateTime.Parse("9:00");
            ArbeitsZeitKlasse StempelPaar3 = new(eingangStempel3, ausgangsStempel3);
            Console.WriteLine(StempelPaar3);


        }
    }
}