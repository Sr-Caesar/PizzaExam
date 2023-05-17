
namespace DecoratorPizzas
{
    public static class OrderHandler
    {
        public static string[] GetPizzaFromOrder(string order)
        {
            string[] myBase = order.Split(';');
            if (myBase.Length > 2)
                return GetExtras(order);
            return myBase;
        }
        private static string[] GetExtras(string order)
        {
            string[] myBase = order.Split(';');
            string[] myExtras = myBase[2].Split(",");
            Array.Resize(ref myBase, myBase.Length -1);
            string[] fullOrder = myBase.Concat(myExtras).ToArray();
            return fullOrder;
        }
    }
}
