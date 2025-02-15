using static Assignment01_Linq.ListGenerator;
namespace Assignment01_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Test
            //var employee = new {name = "sherouk", age = 23, salary=15000m};
            //Console.WriteLine(employee.name);

            //var updatemployee = employee with { name= "dshtdty"};

            //int[] numbers = [1,2,3,4,5,6,8,9];

            ////var oddnumber = from x in numbers
            ////                where x % 2 == 1
            ////                select x;


            //var oddnumber = numbers.Where(x => x % 2 == 1);

            //Console.WriteLine(string.Join(", ", oddnumber)); 
            #endregion

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

            #region LINQ – Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.

            // var Product = ProductList.Select(product => product.ProductName);
            //var Product = from product in ProductList
            //              select product.ProductName;


            // foreach (var product in Product)
            //     Console.WriteLine(product);


            #endregion



            String[] words = {"aPPLE", "BlUeBeRrY", "cHeRry" };

            var wordCases = words.Select(word => new { Upper = word.ToUpper(), Lower = word.ToLower() });

            foreach (var word in wordCases)
            {
                Console.WriteLine($"Upper: {word.Upper}, Lower: {word.Lower}");
            }


            #endregion




        }
    }
}
