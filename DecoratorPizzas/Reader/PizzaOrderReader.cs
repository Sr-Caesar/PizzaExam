//using DocumentFormat.OpenXml.ExtendedProperties;
//using System;
//using System.IO;

namespace DecoratorPizzas.Reader
{
    public class PizzaOrderReader
    {
        private const string RootFilePath = @"C:\Users\Giuli\source\repos\PizzeriaExam\Ordini Pizze\";
        private string _entireFilePath;

        public PizzaOrderReader(string nuovoOrdine)
        {
            if (nuovoOrdine.Split('.').Any())
            {
                _entireFilePath = Path.Combine(RootFilePath, nuovoOrdine);
            }
            else
            {
                nuovoOrdine = $"{nuovoOrdine}.csv";
                _entireFilePath = Path.Combine(RootFilePath, nuovoOrdine);
            }
        }
        public string GetPizzaOrder()
        {
            string pizzaOrder = string.Empty;
            using StreamReader reader = new StreamReader( _entireFilePath );
            pizzaOrder = reader.ReadToEnd();
            return pizzaOrder;
        }
    }
}
