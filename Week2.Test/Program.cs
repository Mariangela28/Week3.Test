using System;
using System.Collections;

namespace Week2.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Benvenuto!");
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
                switch (key)
                {
                    case '1':
                        //TO DO: metodo per inserire username e password, metodo da inserire in utente
                        Utente.InserisciDatiAccesso();

                        break;
                    case '2':
                        //TODO: Aggiungere prodotto al carrello 
                        ProdottiVenduti.AggiungiProdotto();

                        break;
                    case '3':
                        //TODO: Elimina prodotto dal carrello
                        

                        break;
                    case '4':
                        //TODO:Modifica quantità

                        break;
                    case '5':
                        //TODO: Stampa riepilogo del carrello
                        Ordine.GetRiepilogoOrdine();
                        break;
                    case 'q':
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Ritorna");
                        break;
                }





            } while (!quit);
        }
    }
}

