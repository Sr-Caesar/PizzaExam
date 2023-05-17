

namespace DecoratorPizzas.dough
{
    public class WholemealDough : PizzaDecorator
    {
        public WholemealDough(IPizza pizza) : base(pizza)
        {
            _name = "\tImpasto Integrale +1€ (extra)\n";
            _price = 1;
        }
    }
}
