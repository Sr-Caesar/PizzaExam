
namespace DecoratorPizzas
{
    public class Receipt
    {
        private static int ID_order;
        private readonly int _id;
        private readonly double _price;
        private readonly string _order;
        public Receipt(IPizza pizza)
        {
            ID_order++;
            _id = ID_order;
            _price = pizza.GetCost();
            _order = pizza.GetDescription();
        }
        public string Dettails()
        {
            string myRecive = $"Identificativo: {_id} \nPrezzo: {_price} \nDettagli Ordine: {_order}";
            return myRecive;
        }
        public void Visualize()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"  Scontrino Numero: {_id} \n  Dettagli Ordine:\n {_order}  TOTALE: {_price}€");
        }
    }
}
