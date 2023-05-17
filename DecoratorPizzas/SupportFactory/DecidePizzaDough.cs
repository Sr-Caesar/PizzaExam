
using DecoratorPizzas.dough;

namespace DecoratorPizzas.SupportFactory
{
    public static class DecidePizzaDough 
    {
        public static IPizza FromThis(IPizza pizza, string[] myOrder)
        {
            switch (myOrder[1])
            {
                case "normale":
                    pizza = new NormalDough(pizza);
                    break;
                case "integrale":
                    pizza = new WholemealDough(pizza);
                    break;
            }
            return pizza;
        }
    }
}
