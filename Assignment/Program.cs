using System.Runtime.Intrinsics.X86;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;
using static Assignment.ListGenerator;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            ////LINQ - Restriction Operators
            ////1.Find all products that are out of stock.

            //var result = ProductList.Where(P=>P.UnitsInStock==0);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 

            ////////////////////////////////////////////////////////////////////
            ////2. Find all products that are in stock and cost more than 3.00 per unit.

            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice> 3.00M);


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 

            //////////////////////////////////////////////////////////////////////
            ////3. Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Select((name, index) => new { Name = name, Value = index })
            //                .Where(d => d.Name.Length < d.Value)
            //                .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region LINQ - Element Operators
            ////LINQ - Element Operators
            ////1.Get first Product out of Stock

            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 0);

            //Console.WriteLine(result != null ? result.ToString() : "No product found");

            ///////////////////////////////////////////////////////////////////////

            ////2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ProductList.FirstOrDefault(P=>P.UnitPrice>1000);

            //Console.WriteLine(result != null ? result.ToString() : "No product found");


            //////////////////////////////////////////////////////////////////////////
            ////3.Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Where(N => N > 5).ElementAtOrDefault(1);

            //Console.WriteLine(result); 
            #endregion


            #region LINQ - Aggregate Operators

            ////LINQ - Aggregate Operators
            ////1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int result = Arr.Count(N => N%2 != 0);
            //Console.WriteLine(result);

            /////////////////////////////////////////////////////////////////////

            ////2. Return a list of customers and how many orders each has.
            //var result = CustomerList.Select(C => new { C.CustomerName, OrderCount = C.Orders.Count() }).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //////////////////////////////////////////////////////////////////////

            ////3.Return a list of categories and how many products each has
            //var result = ProductList.Select(P => new {P.Category,NumberOfProduct = P.Category.Count() }).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////////////////////////////////////////////////////////////////////////

            ////4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int result = Arr.Sum();

            //Console.WriteLine($"Number of Sum: {result}");

            /////////////////////////////////////////////////////////////////////////

            //string filePath = @"D:\routebackend\LINQ\Session2\dictionary_english.txt";
            //string[] words = File.ReadAllLines(filePath);

            ////5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //int result = words.Sum(w => w.Length);

            //Console.WriteLine($"Number of characters: {result}");

            //////////////////////////////////////////////////////////////////////////

            ////6.Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //int result = words.Min(w => w.Length);

            //Console.WriteLine($"Shortest word length: {result}");

            //////////////////////////////////////////////////////////////////////////

            ////7.Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //int result = words.Max(w => w.Length);

            //Console.WriteLine($"Longest word length: {result}");

            //////////////////////////////////////////////////////////////////////////

            ////8.Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //double result = words.Average(w => w.Length);

            //Console.WriteLine($"Average length: {result}");

            /////////////////////////////////////////////////////////////////////////

            ////9. Get the total units in stock for each product category.
            //var result = ProductList.GroupBy(P => P.Category)
            //                        .Select(C => new { Category = C.Key, TotalUnits = C.Sum(P => P.UnitsInStock) })
            //                        .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////////////////////////////////////////////////////////////////////////

            ////10.Get the cheapest price among each category's products
            //var result = ProductList.GroupBy(P => P.Category)
            //                        .Select(C => new { Category = C.Key, MinPrice = C.Min(P => P.UnitPrice) })
            //                        .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////////////////////////////////////////////////////////////////////////

            ////11.Get the products with the cheapest price in each category (Use Let)
            //var result = ProductList.GroupBy(P => P.Category)
            //                        .Select(group =>
            //                        new
            //                        {
            //                            CategoryName = group.Key,
            //                            CheapestPrice = group.Min(P => P.UnitPrice),
            //                            CheapestProducts = group.Where(P => P.UnitPrice == group.Min(P2 => P2.UnitPrice)).ToList()
            //                        });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.CategoryName}, Cheapest Price: {item.CheapestPrice}");

            //    foreach (var product in item.CheapestProducts)
            //    {
            //        Console.WriteLine($"{product.ProductName} ({product.UnitPrice})");
            //    }
            //}

            ///////////////////////////////////////////////////////////////////////////

            ////12.Get the most expensive price among each category's products.
            //var result = ProductList.GroupBy(p => p.Category)
            //                                .Select(g => new { Category = g.Key, MaxPrice = g.Max(p => p.UnitPrice) })
            //                                .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////////////////////////////////////////////////////////////////////////////

            ////13. Get the products with the most expensive price in each category.


            //var result = ProductList.GroupBy(P => P.Category)
            //                                    .Select(G => new
            //                                    {
            //                                        G.Key,
            //                                        MostExpensiveProducts = G.Where(P => P.UnitPrice == G.Max(P2 => P2.UnitPrice)).ToList()
            //                                    })
            //                                    .ToList();

            //foreach (var category in result)
            //{
            //    Console.WriteLine($"{category.Key}:");
            //    foreach (var product in category.MostExpensiveProducts)
            //    {
            //        Console.WriteLine($"  {product.ProductName} - {product.UnitPrice:C}");
            //    }
            //}

            ////////////////////////////////////////////////////////////////////////////////

            ////14. Get the average price of each category's products.

            //var result =ProductList.GroupBy(P => P.Category)
            //                            .Select(G => new { Category = G.Key, AveragePrice = G.Average(P => P.UnitPrice) })
            //                            .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region LINQ - Ordering Operators
            ////LINQ - Ordering Operators

            ////1.Sort a list of products by name

            //var result = ProductList.OrderBy(P => P.ProductName);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            ////////////////////////////////////////////////////////////

            ////2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(w => w, new ComparerListCaseInsenstive()).ToArray();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            /////////////////////////////////////////////////////////////

            ////3. Sort a list of products by units in stock from highest to lowest.
            //var result = ProductList.OrderByDescending(P => P.UnitsInStock);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //////////////////////////////////////////////////////////////

            ////4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.OrderBy(word => word.Length).ThenBy(word => word);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //////////////////////////////////////////////////////////////

            ////5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(word => word.Length).ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //////////////////////////////////////////////////////////////

            ////6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var result = ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////////////////////////////////////////////////////////////////

            ////7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(word => word.Length).ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            /////////////////////////////////////////////////////////////

            ////8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var result = Arr.Where(word => word.Length > 1 && word[1] == 'i').Reverse();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region LINQ – Transformation Operators
            ////LINQ – Transformation Operators

            ////1. Return a sequence of just the names of a list of products.

            //var result = ProductList.Select(P => P.ProductName);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            /////////////////////////////////////////////////////////////////

            ////2.Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result = words
            //    .Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() })
            //    .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            ////////////////////////////////////////////////////////////////

            ////3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var result = ProductList.Select(P => new { P.ProductName, Price = P.UnitPrice, P.Category }).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////////////////////////////////////////////////////////////////

            ////4. Determine if the value of int in an array matches their position in the array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = Arr.Select((N, Index) => new { Number = N, Index = Index, Matches = N == Index }).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Number}: {item.Matches}");
            //}

            /////////////////////////////////////////////////////////////////

            ////5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = numbersA.SelectMany(A => numbersB.Where(B => A < B), (a, b) => new { A = a, B = b }).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.A} is less than {item.B}");
            //}

            //////////////////////////////////////////////////////////////////////

            ////6. Select all orders where the order total is less than 500.00.
            //var result = CustomerList.SelectMany(C => C.Orders.Where(O => O.Total > 500.00M));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////////////////////////////////////////////////////////////////////////

            ////7.Select all orders where the order was made in 1998 or later.

            //var result = CustomerList.SelectMany(C => C.Orders.Where(O => O.OrderDate.Year >= 1998));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region LINQ - Set Operators
            ////LINQ - Set Operators

            ////1.Find the unique Category names from Product List
            //var result = ProductList.Select(P=>P.Category).Distinct();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////////////////////////////////////////////////////////////

            ////2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var result = ProductList.Select(P => P.ProductName[0])
            //                        .Union(CustomerList.Select(C => C.CustomerName[0]))
            //                        .Distinct()
            //                        .ToList(); 

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            ///////////////////////////////////////////////////////////

            ////3.Create one sequence that contains the common first letter from both product and customer names.

            //var result = ProductList.Select(P => P.ProductName[0])
            //                                    .Intersect(CustomerList.Select(C => C.CustomerName[0]))
            //                                    .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            /////////////////////////////////////////////////////////////////

            ////4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var result = ProductList.Select(P => P.ProductName[0])
            //                                    .Except(CustomerList.Select(C => C.CustomerName[0]))
            //                                    .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            /////////////////////////////////////////////////////////////////////

            ////5.Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var result = ProductList.Select(P => new string(P.ProductName.TakeLast(3).ToArray()))
            //                        .Concat(CustomerList.Select(C => new string(C.CustomerName.TakeLast(3).ToArray())));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region LINQ - Partitioning Operators
            ////LINQ - Partitioning Operators
            ////1.Get the first 3 orders from customers in Washington

            //var result = CustomerList.Where(C => C.Region == "WA") .SelectMany(C => C.Orders).Take(3);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            /////////////////////////////////////////////////////////////

            ////2.Get all but the first 2 orders from customers in Washington.
            //var result = CustomerList.Where(C => C.Region == "WA").SelectMany(C => C.Orders).Skip(2);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////////////////////////////////////////////////////////////

            ////3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((N, Index) => N >= Index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //////////////////////////////////////////////////////////////////

            ////4.Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(num => num % 3 != 0);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ///////////////////////////////////////////////////////////////////

            ////5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((num, index) => num >= index) ;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region LINQ - Quantifiers
            ////LINQ - Quantifiers

            ////1.Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //string filePath = @"D:\routebackend\LINQ\Session2\dictionary_english.txt";
            //string[] words = File.ReadAllLines(filePath);

            //bool Flag = words.Any(w => w.Contains("ei"));

            //Console.WriteLine(Flag);

            //////////////////////////////////////////////////////

            ////2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var result = ProductList.GroupBy(P => P.Category)
            //                        .Where(G => G.Any(P => P.UnitsInStock == 0));

            //foreach (var category in result)
            //{
            //    Console.WriteLine($"Category: {category.Key}");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($"{product.ProductName} (Stock: {product.UnitsInStock})");
            //    }
            //}


            //////////////////////////////////////////////////////

            ////3. Return a grouped a list of products only for categories that have all of their products in stock
            //var result =ProductList.GroupBy(P => P.Category)
            //                                        .Where(G => G.All(P => P.UnitsInStock > 0));

            //foreach (var category in result)
            //{
            //    Console.WriteLine($"Category: {category.Key}");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($"  {product.ProductName} (Stock: {product.UnitsInStock})");
            //    }
            //} 
            #endregion


            #region LINQ – Grouping Operators
            ////LINQ – Grouping Operators

            ////1.Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result = numbers.GroupBy(N => N % 5).ToList();

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Numbers with remainder {group.Key} when divided by 5:");
            //    foreach (var num in group)
            //    {
            //        Console.WriteLine($"  {num}");
            //    }
            //}

            ///////////////////////////////////////////////////////////////

            ////2.Uses group by to partition a list of words by their first letter.
            ////Use dictionary_english.txt for Input

            //string filePath = @"D:\routebackend\LINQ\Session2\dictionary_english.txt";
            //string[] words = File.ReadAllLines(filePath);

            //var result = words.Where(w => !string.IsNullOrWhiteSpace(w)) 
            //                  .GroupBy(w => char.ToUpper(w[0])).ToList();

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Words starting with '{group.Key}':");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine($"  {word}");
            //    }
            //}


            //////////////////////////////////////////////////////////////

            ////3.Use Group By with a custom comparer that matches words that are consists of the same Characters Together

            //string[] Arr = { "from", "salt", "earn", "last", "near", "form" };

            //var result = Arr
            //    .GroupBy(w => new string(w.OrderBy(C => C).ToArray())).ToList();

            //foreach (var group in result)
            //{
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine($"{word} ");
            //    }
            //} 
            #endregion

        }
    }
}
