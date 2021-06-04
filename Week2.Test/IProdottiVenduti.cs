using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Test
{
    public interface IProdottiVenduti
    {
        int Codice { get; set; }
        string Descrizione { get; set; }
        double Prezzo { get; set; }
        double PercentualeSconto { get; set; }
    }
}
