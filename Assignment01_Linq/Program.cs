using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
using System.Threading;
using static Assignment01_Linq.ListGenerator;
namespace Assignment01_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            #region LINQ - Restriction Operators

            #region Find all products that are out of stock.

            //var Product = ProductList.Where(x => x.UnitsInStock == 0);

            //var Product = from product in ProductList
            //          where product.UnitsInStock == 0
            //          select product;

            //foreach (var product in Product)
            //{
            //    Console.WriteLine(product);
            //} 

            #endregion

            #region 2.Find all products that are in stock and cost more than 3.00 per unit.

            // var Product = ProductList.Where(product => product.UnitsInStock > 1 && product.UnitPrice > 3.00m);


            //var Product = from product in ProductList
            //              where product.UnitsInStock > 0 && product.UnitPrice > 3.00m
            //              select product;


            //foreach (var product in Product)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region 3. Returns digits whose name is shorter than their value.


            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var shortNamedDigits = Arr.Select((name, index) => new { Name = name, Value = index })
            //                                 .Where(digit => digit.Name.Length < digit.Value);

            //foreach (var digit in shortNamedDigits)
            //    Console.WriteLine(digit.Name);

            #endregion

            #endregion

            #region LINQ - Ordering Operators

            #region Sort a list of products by name

            //var Product = ProductList.OrderBy(Product => Product.ProductName);

            //foreach (var item in Product)
            //    Console.WriteLine(item);

            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in sortedWords)
            //    Console.WriteLine(word);


            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.

            //var Product = ProductList.OrderByDescending(Product => Product.UnitsInStock);

            //foreach (var item in Product)
            //    Console.WriteLine(item);



            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.


            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var sortedDigits = Arr.OrderBy(name => name.Length).OrderBy(name => name);  


            //foreach(var digit in sortedDigits) 
            //    Console.WriteLine(digit);


            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.


            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = Arr.OrderBy(word => word.Length).OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in sortedWords)
            //    Console.WriteLine(word);

            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.


            //var Product = ProductList.OrderBy(Product => Product.Category).OrderByDescending(Product => Product.UnitPrice);

            //foreach (var item in Product)
            //    Console.WriteLine(item);


            #endregion


            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = Arr.OrderBy(word => word.Length).OrderByDescending(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in sortedWords)
            //    Console.WriteLine(word);

            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var filteredReversedDigits = Arr.OrderBy(word => word.Length > 1 && word[1] == 'i').Reverse();

            //foreach (var item in filteredReversedDigits)
            //    Console.WriteLine(item);


            #endregion


            #endregion

            #region LINQ – Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.

            // var Product = ProductList.Select(product => product.ProductName);
            //var Product = from product in ProductList
            //              select product.ProductName;


            // foreach (var product in Product)
            //     Console.WriteLine(product);


            #endregion


            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).


            //String[] words = {"aPPLE", "BlUeBeRrY", "cHeRry" };

            //var wordCases = words.Select(word => new { Upper = word.ToUpper(), Lower = word.ToLower() });

            //foreach (var word in wordCases)
            //{
            //    Console.WriteLine($"Upper: {word.Upper}, Lower: {word.Lower}");
            //}

            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var Product = ProductList.Select(product => new { product.ProductName, Price = product.UnitPrice });

            //var Product = from product in ProductList
            //              select new { product.ProductName, Price = product.UnitPrice };


            //foreach (var product in Product)
            //    Console.WriteLine(product);

            #endregion

            #region 4. Determine if the value of int in an array match their position in the array.


            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var matchingValues = Arr.Select((value, index) => new { Number = value, InPlace = (value == index) });

            //foreach (var value in matchingValues)
            //    Console.WriteLine(value);

            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.


            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var pairs = numbersA.SelectMany(a => numbersB.Where(b => a < b).Select(b => new { A = a, B = b }));

            //foreach (var pair in pairs)
            //{
            //    Console.WriteLine($"{pair.A} is less than {pair.B}");
            //}


            #endregion

            #region 6. Select all orders where the order total is less than 500.00.

            //var orders = CustomerList.SelectMany(customer => customer.Orders).Where(order => order.Total < 500.00m);

            //foreach (var order in orders) 
            //    Console.WriteLine(order);

            #endregion

            #region 7. Select all orders where the order was made in 1998 or later.


            //var orders = CustomerList.SelectMany(customer => customer.Orders).Where(order => order.OrderDate.Year >= 1998);

            //foreach (var order in orders)
            //    Console.WriteLine(order);

            #endregion

            #endregion




        }
    }
}
