using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Test
{
    class Elettronica : ProdottiVenduti
    {
        public string Produttore { get; set; }

        public Elettronica(int codice, string descrizione, double prezzo, double percentualeSconto, string produttore) : base(codice, descrizione, prezzo, percentualeSconto, produttore)
        {
            Produttore = produttore;
        }
    }
}
