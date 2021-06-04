using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Test
{
    public class Abbigliamento : ProdottiVenduti
    {
        public string Taglia { get; set; }
        public string Brand { get; set; }
        public Abbigliamento(int codice, string descrizione, double prezzo, double percentualeSconto, string taglia, string brand) : base(codice, descrizione, prezzo, percentualeSconto, taglia, brand)
        {
            Taglia = taglia;
            Brand = brand;
        }
    }
}
