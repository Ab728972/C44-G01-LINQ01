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
            #region Problem 3: Digits with name shorter than value
            {
                Console.WriteLine("=== Digits with name shorter than value ===");
                string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

                var result = digits.Where((name, index) => name.Length < index);

                foreach (var item in result)
                {
                    Console.WriteLine($"{Array.IndexOf(digits, item)}: {item}");
                }
                Console.WriteLine();
            }
            #endregion
            #region Problem 4: First product out of stock
            {
                Console.WriteLine("=== First product out of stock ===");
                var firstOutOfStock = ListGenerators.ProductList.FirstOrDefault(p => p.UnitsInStock == 0);

                if (firstOutOfStock != null)
                {
                    Console.WriteLine($"{firstOutOfStock.ProductName} - {firstOutOfStock.UnitPrice:C}");
                }
                else
                {
                    Console.WriteLine("No out of stock products found");
                }
                Console.WriteLine();
            }
            #endregion
            #region Problem 5: First product with price > 1000 or null
            {
                Console.WriteLine("=== First product with price > $1000 ===");
                var expensiveProduct = ListGenerators.ProductList.FirstOrDefault(p => p.UnitPrice > 1000m);

                Console.WriteLine(expensiveProduct?.ProductName ?? "No product found with price > $1000");
                Console.WriteLine();
            }
            #endregion
        }

    }
}
