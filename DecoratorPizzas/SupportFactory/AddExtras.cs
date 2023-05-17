
using DecoratorPizzas.Extras;

namespace DecoratorPizzas.SupportFactory
{
    public static class AddExtras
    {
        public static IPizza FromThis(IPizza pizza, string[] myOrder)
        {
            for (int i = 2;  i < myOrder.Length; i++)
            {
                switch (myOrder[i])
                {
                    case "prosciuttocrudo":
                        pizza = new RawHam(pizza);
                        break;
                    case "funghi":
                        pizza = new Mushrooms(pizza);
                        break;
                    case "prosciuttocotto":
                        pizza = new BackedHam(pizza);
                        break;
                    case "ananas":
                        pizza = new Ananas(pizza);
                        break;
                }
            }
            return pizza;
        }
    }
}
