
using DecoratorPizzas.Bases;
using DecoratorPizzas.dough;
using DecoratorPizzas.SupportFactory;

namespace DecoratorPizzas
{
    public class FactoryPizza
    {
        public static IPizza GetPizza(string order)
        {
            if (string.IsNullOrEmpty(order))
            {
                throw new ArgumentException("Non è stato inserito nessun ordine!", nameof(order));
            }
            string[] myOrder = OrderHandler.GetPizzaFromOrder(order)
                      .Select(x => x.ToLower())
                      .ToArray();
            IPizza pizza = DecidePizzaBase.FromThis(myOrder);
            pizza = DecidePizzaDough.FromThis(pizza,myOrder);
            pizza = AddExtras.FromThis(pizza,myOrder);

            return pizza;
        }
    }
}
