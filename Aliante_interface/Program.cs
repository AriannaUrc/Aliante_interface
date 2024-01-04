using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea aliante
            Aliante aliante = new Aliante();

            //Aggiungi informazioni Ala
            Console.WriteLine("Inserisci informazioni Ala: \n");

            Console.Write("Costo: ");
            double costo = double.Parse(Console.ReadLine());
            Console.Write("Lunghezza: ");
            double lunghezza = double.Parse(Console.ReadLine());
            Console.Write("Apertura: ");
            double apertura = double.Parse(Console.ReadLine());

            Ala ala = new Ala(lunghezza, apertura, costo);

            aliante.Add(ala);


            //Aggiungi informazioni Coda
            Console.WriteLine("\n\nInserisci informazioni Coda: \n");

            Console.Write("Costo: ");
            costo = double.Parse(Console.ReadLine());
            Console.Write("Lunghezza: ");
            lunghezza = double.Parse(Console.ReadLine());

            Coda coda = new Coda(lunghezza, costo);

            aliante.Add(coda);


            //Aggiungi informazioni Fusoliera
            Console.WriteLine("\n\nInserisci informazioni Fusoliera: \n");

            Console.Write("Costo: ");
            costo = double.Parse(Console.ReadLine());
            Console.Write("Lunghezza: ");
            lunghezza = double.Parse(Console.ReadLine());
            Console.Write("Lunghezza: ");
            string materiale = Console.ReadLine();

            Fusoliera fusoliera = new Fusoliera(lunghezza, materiale, costo);

            aliante.Add(fusoliera);


            //Aggiungi informazioni Ruota
            Console.WriteLine("\n\nInserisci informazioni Fusoliera: \n");

            Console.Write("Costo: ");
            costo = double.Parse(Console.ReadLine());
            Console.Write("Lunghezza: ");
            lunghezza = double.Parse(Console.ReadLine());
            Console.Write("pollici_materiale: ");
            int pollici_materiale = int.Parse(Console.ReadLine());
            Console.Write("Altezza: ");
            double altezza = double.Parse(Console.ReadLine());
            Console.Write("Raggio: ");
            double raggio = double.Parse(Console.ReadLine());


            Ruota ruota = new Ruota(lunghezza, altezza, pollici_materiale, raggio, costo);

            aliante.Add(ruota);



            //costo totale e descrizione
            Console.WriteLine("\n\n\nCosto totale: " + aliante.Costo() + "\nDescrizione: " + aliante.Descrizione());
        }
    }
}
