namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prodotto felpa = new Prodotto("Nike", "felpone felpato", 29.99);
            felpa.stampaProdotto();

            Prodotto scarpa = new Prodotto("Scarpone", "Sandalo tedesco", 27.99);
            scarpa.stampaProdotto();
        }
    }
}