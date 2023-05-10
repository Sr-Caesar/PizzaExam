using DecoratorPizzas;
using Microsoft.VisualBasic;

IPizza pizza = FactoryPizza.GetPizza("Napoletana;Integrale;ProsciuttoCotto,Funghi");

Receipt myRecive = new(pizza);
myRecive.Visualize();
//Console.WriteLine($"{pizza.GetDescription()}-{pizza.GetCost()}");

