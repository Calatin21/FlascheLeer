namespace FlascheLeer {
    internal class Flasche<T> where T : Getraenk {
        T Value;
        public String Inhalt { get; set; }
        public bool IstLeer() {
            bool ergebnis = false;
            if (Value == null) {
                ergebnis = true;
            }
            return ergebnis;
        }
        public void Fuellen(T t, String typ) {
            Value = t;
            Inhalt = typ;
        }
        public T Leeren() {
            T inhalt = Value;
            Value = null;
            return inhalt;
        }
    }
}
