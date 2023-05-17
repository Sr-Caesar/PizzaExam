

namespace DecoratorPizzas.Extras
{
    public class Ananas : PizzaDecorator
    {
        public Ananas(IPizza pizza) : base(pizza)
        {
            _name = "\tExtra di Ananas (!!!)\n";
            _price = 0;
        }
    }
}
