public class PersonenDaten
{
    public string Vorname { get; set; }
    public string Nachname { get; set; }
    public DateTime? Geburtsdatum { get; set; }
    public string Lieblingsfarbe { get; set; } // Hinzugefügt, um CS1061 zu beheben
    public List<string> Betriebssysteme { get; set; }
    public string Geschlecht { get; set; }
    public string Hobbies { get; set; }
}
@using DatenEingabe
@model PersonenDaten

<!DOCTYPE html>
<h2> Ihre Eingegebenen Daten:</ h2 >
< p > Vorname: @Model.Vorname </ p >
< p > Nachname: @Model.Nachname </ p >
< p > Geburtsdatum: @(Model.Geburtsdatum?.ToShortDateString()) </ p >
< p > Lieblingsfarbe: < span style = "background-color:@Model.Lieblingsfarbe" > @Model.Lieblingsfarbe </ span ></ p >
< p > Betriebssystem: @string.Join(", ", Model.Betriebssysteme ?? new List<string>()) </ p >
< p > Geschlecht: @Model.Geschlecht </ p >
< p > Hobbies: @Model.Hobbies </ p >
