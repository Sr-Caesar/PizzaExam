using DecoratorPizzas;

var pizza = FactoryPizza.GetPizza("Margherita;Normale");

Console.WriteLine($"{pizza.GetDescription}-{pizza.GetCost}");