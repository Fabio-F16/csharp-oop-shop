using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        public int Codice { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public double prezzo;
        public double iva;

        public Prodotto(string nome, string descrizione, double prezzo)
        {
            Codice = new Random().Next(1, 999999999);
            Nome = nome;
            Descrizione = descrizione;
            this.prezzo = prezzo ;
        }



        public double Iva
        {
            get { return iva = 0.21; }
        }



        public int GetCodice()
        {
            Random rnd = new Random();
            int num = rnd.Next();
            this.Codice = num;
            return this.Codice;
        }

        public string GetNome()
        {
            return $"{Codice} - {Nome}";
        }


        public void stampaProdotto()
        {
            Console.WriteLine("il nome è: " + this.GetNome());
            Console.WriteLine("La descrizione è: " + this.Descrizione);
            Console.WriteLine("il prezzo è: " + this.prezzo);
            Console.WriteLine("il codice è: " + this.Codice);

        }



    }
}
