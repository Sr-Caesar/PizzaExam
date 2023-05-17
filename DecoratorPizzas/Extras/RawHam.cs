
namespace DecoratorPizzas.Extras
{
    public class RawHam : PizzaDecorator
    {
        public RawHam(IPizza pizza) : base(pizza)
        {
            _name = "\tExtra di ProsciuttoCrudo +2€ (extra)\n";
            _price = 2;
        }
    }
}
