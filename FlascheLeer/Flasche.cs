namespace FlascheLeer {
    internal class Flasche<T> where T : Getraenk {
        T Inhalt;
        public String InhaltInWorten { get; set; }
        public bool IstLeer() {
            if (Inhalt == null) {
                return true;
            }
            else {
                 return false; }
        }
        public void Fuellen(T t, String typ) {
            Inhalt = t;
            Inhalt = typ;
        }
        public T Leeren() {
            T inhalt = Inhalt;
            Inhalt = null;
            return inhalt;
        }
    }
}
