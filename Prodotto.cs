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
        public string Descrizione { get; set;}
        public double Prezzo { get; set; }
        private double iva;

        public Prodotto(string nome, string descrizione, double prezzo)
        {
            Codice = new Random().Next(10, 99);
            Nome = nome;
            Descrizione = descrizione;
            this.Prezzo = prezzo;
        }

        public double GetIvaPrice()
        {
            this.iva = 21.00;
            double fullPrice = this.Prezzo + (this.Prezzo * iva) / 100;
            return fullPrice;
        }
     
        // nome + codice
        public string GetNomeCodice()
        {
            string codiceConNome = this.Codice.ToString();
            return codiceConNome + "-" + this.Nome;
        }
        // codice con pad left
        public string codicePadLeft()
        {
            string codiceBase = this.Codice.ToString();
            while(codiceBase.Length < 8)
            {
                codiceBase = "0" + codiceBase;
            }
            return codiceBase;
        }

        // stampa prodotto
        public void stampaProdotto()
        {
            Console.WriteLine("il nome è: " + this.Nome);
            Console.WriteLine("il nome con codice è: " + this.GetNomeCodice());
            Console.WriteLine("La descrizione è: " + this.Descrizione);
            Console.WriteLine("il prezzo base è: " + this.Prezzo);
            Console.WriteLine("il prezzo con l'iva è: " + this.GetIvaPrice());
            Console.WriteLine("il codice è: " + this.codicePadLeft());
            Console.WriteLine("------------------------");
        }
    }
}
