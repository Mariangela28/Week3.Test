using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Test
{
    public class ProdottiVenduti : IProdottiVenduti
    {
        public int Codice { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public double PercentualeSconto { get; set; }

        private IList<Ordine> _ordini = new List<Ordine>();
        public ProdottiVenduti(int codice, string descrizione, double prezzo, double percentualeSconto)
        {
            Codice = codice;
            Descrizione = descrizione;
            Prezzo = prezzo;
            PercentualeSconto = percentualeSconto;
        }

        public ProdottiVenduti(int codice, string descrizione, double prezzo, double percentualeSconto, string produttore) : this(codice, descrizione, prezzo, percentualeSconto)
        {
        }

        public ProdottiVenduti(int codice, string descrizione, double prezzo, double percentualeSconto, string produttore, string brand) : this(codice, descrizione, prezzo, percentualeSconto, produttore)
        {
        }
    }
}
