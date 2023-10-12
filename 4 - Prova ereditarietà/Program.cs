using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Prova_ereditarietà
{
    class Quadrato
    {
        // attributi
        protected int _lato;

        // costruttore
        public Quadrato(int _lato) 
        {
            Lato = _lato;
        }

        // metodi accessor
        public int Lato
        {
            get { return _lato; }
            set { _lato = value; }
        }

        // metodi
        public int CalcoloArea()
        {

            return _lato * _lato;
        }
        public int CalcoloPerimetro()
        {
            return _lato * 4;
        }
    }

    class Cubo : Quadrato
    {
        public Cubo(int _lato) : base(_lato)
        {

        }

        public int CalcoloSuperficie()
        {
            return 6 * CalcoloArea();
        }
        public int CalcoloVolume()
        {
            return _lato * _lato * _lato;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire il lato: ");
            int lato = int.Parse(Console.ReadLine());
            Cubo c = new Cubo(lato);


            Console.WriteLine($"L'area è: {c.CalcoloArea()}, il perimetro è: {c.CalcoloPerimetro()} ");
            Console.WriteLine($"La superficie tot è: {c.CalcoloSuperficie()}, il volume è: {c.CalcoloVolume()} ");
        }
    }
}
