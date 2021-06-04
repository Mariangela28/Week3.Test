using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Test
{
    public class ProdottiVenduti 
    {
        public int Codice { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public double PercentualeSconto { get; set; }

        public IList<ProdottiVenduti> _prodotti = new List<ProdottiVenduti>();
        public ProdottiVenduti(int codice, string descrizione, double prezzo, double percentualeSconto)
        {
            Codice = codice;
            Descrizione = descrizione;
            Prezzo = prezzo;
            PercentualeSconto = percentualeSconto;
        }

        

        public void AggiungiProdotto(int codice)
        {
            var AggiungiProdotto = new ProdottiVenduti(Codice, Descrizione, Prezzo, PercentualeSconto);
            _prodotti.Add(new ProdottiVenduti(Codice, Descrizione, Prezzo, PercentualeSconto));
            
               
                    
            }

        
        }
    }
    

