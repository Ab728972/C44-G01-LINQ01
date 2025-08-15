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
            #region Problem 2: Find all products in stock costing more than 3.00
            {
                Console.WriteLine("=== Products in stock > $3.00 ===");
                var expensiveInStockProducts = ListGenerators.ProductList
                    .Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);

                foreach (var product in expensiveInStockProducts)
                {
                    Console.WriteLine($"{product.ProductName} - {product.UnitPrice:C} - Stock: {product.UnitsInStock}");
                }
                Console.WriteLine();
            }
            #endregion
        }

    }
}
