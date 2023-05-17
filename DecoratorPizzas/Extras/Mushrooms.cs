
namespace DecoratorPizzas.Extras
{
    public class Mushrooms : PizzaDecorator
    {
        public Mushrooms(IPizza pizza) : base(pizza)
        {
            _name = "\tExtra di Funghi +2€ (extra)\n";
            _price = 2;
        }
    }
}
