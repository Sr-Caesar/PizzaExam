namespace DecoratorPizzas.Bases
{
    public class Margherita : IPizza
    {
        public string GetDescription()
            => "\tPizza Margherita + 7€\n";
        public double GetCost()
            => 7;
    }
}
