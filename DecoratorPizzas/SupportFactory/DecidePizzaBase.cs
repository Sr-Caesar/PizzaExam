
using DecoratorPizzas.Bases;
using System.Runtime.CompilerServices;

namespace DecoratorPizzas
{
    public static class DecidePizzaBase
    {
        public static IPizza FromThis(string[] myOrder)
        {
            IPizza pizza = null;
            switch (myOrder[0])
            {
                case "bianca":
                    pizza = new Bianca();
                    break;
                case "margherita":
                    pizza = new Margherita();
                    break;
                case "napoletana":
                    pizza = new Napoletana();
                    break;
            }
            return pizza;
        }
    }
}
