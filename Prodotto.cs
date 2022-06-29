using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        public int Codice { get; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public double prezzo;
        private double iva;

        public Prodotto(string nome, string descrizione, double prezzo)
        {
            Codice = new Random().Next(1, 999999999);
            Nome = nome;
            Descrizione = descrizione;
            this.prezzo = prezzo ;
        }

        public double GetIvaPrice()
        {

            this.iva = 21.00;
            double fullPrice = this.prezzo + (this.prezzo * iva) / 100;
            return fullPrice;
        }


        // codice
        public int GetCodice()
        {
            return this.Codice;
        }


        // nome + codice
        public string GetNome()
        {
            string codiceConNumero = this.Codice.ToString();
            return codiceConNumero + "-" + this.Nome;
        }


        // stampa prodotto
        public void stampaProdotto()
        {
            Console.WriteLine("il nome è: " + this.GetNome());
            Console.WriteLine("La descrizione è: " + this.Descrizione);
            Console.WriteLine("il prezzo base è: " + this.prezzo);
            Console.WriteLine("il prezzo con l'iva è: " + this.GetIvaPrice());
            Console.WriteLine("il codice è: " + this.Codice);

        }

    }
}
