using System;

namespace Week2.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto");
            bool quit = false;

            char key;

            do
            {
                Console.WriteLine("Premi 1 - Inserisci username e password");
                Console.WriteLine("Premi 2 - Aggiungi prodotto al carrello");
                Console.WriteLine("Premi 3 - Elimina prodotto dal carrello");
                Console.WriteLine("Premi 4 - Modifica quantità");
                Console.WriteLine("Premi 5 - Stampa riepilogo del carrello");
                Console.WriteLine("Premi q - Esci");
                key = Console.ReadKey().KeyChar;
                Console.ReadLine();
            } while (!quit);
        }
    }
}
