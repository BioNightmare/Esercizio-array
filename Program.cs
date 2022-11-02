using System;
using System.Collections.Generic;

namespace Esercizio_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Citta Milano = new("Milano", 100);
            Cittadino Marco = new("Marco", "Neri", Milano);
            Milano.AggiungiCittadino(Marco);
            Console.WriteLine(Milano._listaCittadini);
           
        }
    }
    public class Citta
    {
        public string _nome;
        public int _numeroabitantimax;
        public List<Cittadino> _listaCittadini = new();
        public Citta(string nome, int numeroabitantimax)
        {
            _nome = nome;
            _numeroabitantimax = numeroabitantimax;
        }

        public void AggiungiCittadino(Cittadino nuovoCittadino)
        {
            if (_listaCittadini.IndexOf(nuovoCittadino) == -1 && _listaCittadini.Count < _numeroabitantimax)
            {
                _listaCittadini.Add(nuovoCittadino);
                Console.WriteLine("Cittadini presenti: " + _listaCittadini.Count);
                Console.WriteLine("Spazio disponibile: " + (_numeroabitantimax - _listaCittadini.Count));
            }
            else
            {
                Console.WriteLine("La città è al massimo della capienza");
            }
        }
    }
    public class Cittadino
    {
        public string _nome;
        public string _cognome;
        public Citta _citta;

        public Cittadino(string nome, string cognome, Citta citta)
        {
            _nome = nome;
            _cognome = cognome;
            _citta = citta;
        }
    }

}
