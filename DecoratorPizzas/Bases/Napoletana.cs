namespace DecoratorPizzas.Bases
{
    public class Napoletana : IPizza
    {
        public string GetDescription()
            => "\tPizza Napoletana +3€\n";
        public double GetCost()
            => 3;
    }
}
