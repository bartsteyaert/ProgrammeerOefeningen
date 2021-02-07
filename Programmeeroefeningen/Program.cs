using System;

namespace Programmeeroefeningen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Oefening1();
        }

        public static Kat Oefening1()
        {
            // maak een class Kat
            var kat = new Kat();
            // maak een methode in de class Kat die Spreek() noemt. De spreek methode schrijft "miauw!" in de console
            kat.Spreek();
            // geef de kat een Property naam en zorg dat het nieuwe kat-object de naam "Joske" krijgt

            // zorg dat de kat "Hallo, ik ben Joske." teruggeeft in een methode GeefNaam()
            // opgelet! niet in de console schrijven maar teruggeven als string zodat we die als variable kunnen opslaan.
            string naam = kat.ZegNaam();

            // verander nu de naam naar Josefien
            // zorg dat de methode ZegNaam ook automatisch aanpast zodat die de juiste naam teruggeeft.
            // !Tip: gebruik de juiste property

            return kat;
        }
    }
}