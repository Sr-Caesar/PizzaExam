namespace DecoratorPizzas.Bases
{
    public class Bianca : IPizza
    {
        public string GetDescription()
            => "\tPizza Bianca +5€\n";
        public double GetCost()
            => 5;
    }
}
