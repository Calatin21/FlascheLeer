namespace FlascheLeer {
    internal class Program {
        static void Main(string[] args) {            
            Flasche<Bier> fBier = new Flasche<Bier>();
            Flasche<Rotwein> fWein1 = new Flasche<Rotwein>();
            Flasche<Weißwein> fWein2 = new Flasche<Weißwein>();
            //Flasche<int> fzahl = new Flasche<int>();  //int gehört nicht zur Beschränkung

            Bier guinnes = new Bier() {  Typ = "Bier", Brauerei = "Dublin", information = "Nur gezapft echter Geschmack" };
            fBier.Fuellen(guinnes, guinnes.Typ);

            Rotwein burgunder = new Rotwein() {  Typ = "Rotwein", Herkunft = "Frankreich", Information = "Melone und Ahorn Aromen im Abgang" };
            fWein1.Fuellen(burgunder, burgunder.Typ);

            Weißwein riesling = new Weißwein() { Typ = "Weißwein", Herkunft = "Deutschland", Information = "Birne und Apfel Aromen im Abgang" };
            fWein2.Fuellen(riesling, riesling.Typ);

            Console.WriteLine(fBier.Inhalt);
            Console.WriteLine(fBier.IstLeer());
            Console.WriteLine(fBier.Leeren().Brauerei);
            Console.WriteLine(fBier.IstLeer());
            Console.WriteLine(fWein1.Inhalt);
            Console.WriteLine(fWein1.IstLeer());
            Console.WriteLine(fWein1.Leeren().Herkunft);
            Console.WriteLine(fWein1.IstLeer());
            Console.WriteLine(fWein2.Inhalt);
            Console.WriteLine(fWein2.IstLeer());
            Console.WriteLine(fWein2.Leeren().Herkunft);
            Console.WriteLine(fWein2.IstLeer());

        }
    }
}