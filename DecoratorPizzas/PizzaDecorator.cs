
namespace DecoratorPizzas
{
    public abstract class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;

        protected string _name = String.Empty;
        protected double _price = 0;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public string GetDescription()
            => $"{_pizza.GetDescription()} {_name}";

        public double GetCost()
            => _pizza.GetCost() + _price;

    }
}
