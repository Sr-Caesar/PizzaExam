
namespace DecoratorPizzas.Extras
{
    public class BackedHam : PizzaDecorator
    {
        public BackedHam(IPizza pizza) : base(pizza)
        {
            _name = "\tExtra di ProsciuttoCotto +1€ (extra)\n";
            _price = 1;
        }
    }
}
