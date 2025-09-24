namespace DatenEingabe
{
    public class PersonenDaten
    {
        public string? Vorname { get; set; }
        public string? Nachname { get; set; }
        public DateOnly Geburtsdatum { get; set; }
        public string? Lieblingsfarbe { get; set; }
        public List<string>? Betriebssysteme { get; set; }
        public string? Geschlecht { get; set; }
        public string? Hobbies { get; set; }
    }
}
