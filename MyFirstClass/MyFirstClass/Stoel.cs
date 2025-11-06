using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClass
{
    internal class Stoel
    {
        private string _kleur;
        private int _zithoogte;

        public Stoel(string ingegevenKleur, int ingegevenZithoogte)
        {
            _kleur = ingegevenKleur;
            _zithoogte = ingegevenZithoogte;
        }

        // kleur teruggeven
        public string echoKleur()
        {
            return "De kleur van de stoel is: " + _kleur;
        }

        // zithoogte teruggeven
        public int getZithoogte()
        {
            return _zithoogte;
        }

        // hoogte verstellen
        public void verstellen(int hoogte)
        {
            _zithoogte += hoogte;
            Console.WriteLine("De stoel is met " + hoogte + " cm versteld.");
        }
    }
}
