

namespace DecoratorPizzas.dough
{
    public class NormalDough : PizzaDecorator
    {
        public NormalDough(IPizza pizza) : base(pizza)
        {
            _name = "\tImpasto Normale\n";
            _price = 0;
        }
    }
}
