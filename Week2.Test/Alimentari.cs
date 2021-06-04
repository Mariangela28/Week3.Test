using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Test
{
    class Alimentari : ProdottiVenduti
    {
        public DateTime DataScadenza { get; set; }
        public Alimentari(int codice, string descrizione, double prezzo, double percentualeSconto) : base(codice, descrizione, prezzo, percentualeSconto)
        {
            
        }
        
    }
}
