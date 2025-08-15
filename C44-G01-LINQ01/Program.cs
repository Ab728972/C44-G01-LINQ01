namespace C44_G01_LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1: Find all products that are out of stock
            {
                Console.WriteLine("=== Products out of stock ===");
                var outOfStockProducts = ListGenerators.ProductList.Where(p => p.UnitsInStock == 0);
                foreach (var product in outOfStockProducts)
                {
                    Console.WriteLine($"{product.ProductName} - {product.UnitPrice:C}");
                }
                Console.WriteLine();
            }
            #endregion
        }

    }
}
