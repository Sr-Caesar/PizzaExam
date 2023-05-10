using DecoratorPizzas;

var pizza = FactoryPizza.GetPizza("Napoletana;Integrale;ProsciuttoCotto,Funghi");
Console.WriteLine($"{pizza.GetDescription()}-{pizza.GetCost()}");

