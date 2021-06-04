using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Test
{
    public class Ordine
    {
        public string Prodotto { get; set; }
        public int QuantitàOrdinata { get; set; }
        public double PrezzoTotale { get; set; }
        public static  double PrezzoTotaleScontato { get; set; }

        public static IList<Ordine> _ordini = new List<Ordine>();


        public Ordine(string prodotto, int quantitàOrdinata, double prezzoTotale, double prezzoTotaleScontato)
        {
            Prodotto = Prodotto;
            QuantitàOrdinata = quantitàOrdinata;
            PrezzoTotale = prezzoTotale; 

        }
        public override string ToString()
        {
            return $"{Prodotto} \t {QuantitàOrdinata} \t {PrezzoTotale} \t {PrezzoTotaleScontato}";
        }

        public static string GetRiepilogoOrdine()
        {
            var riepilogoOrdine = new StringBuilder();
            
            riepilogoOrdine.Append("Prodotto \t QuantitàOrdinata \t PrezzoTotale \n");  
            foreach (var ordine in _ordini)
            {
                riepilogoOrdine.Append(ordine.ToString());
            }
            riepilogoOrdine.Append($"------ PrezzoFinale \t \t: {PrezzoTotaleScontato}");
            return riepilogoOrdine.ToString(); 
        }
    }
}

