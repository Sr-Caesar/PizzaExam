using DecoratorPizzas;
using DecoratorPizzas.Reader;

var a = new PizzaOrderReader("pizza1.csv");
var mioOrdine = a.GetPizzaOrder();
IPizza pizza = FactoryPizza.GetPizza(mioOrdine);
Receipt myRecive = new(pizza);
myRecive.Visualize();
