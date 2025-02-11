using System.Collections;
using static Session2Demo.ListGenerator;

namespace Session2Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ : 40+ Extention Methods
            //LINQ : 13 Category 

            #region 1.Filteration Operators = Where / OfType
            //// 1.Filteration Operators = Where / OfType

            ////All Product Out stock

            ////Fluent Syntax
            ////var result =ProductList.Where(P => P.UnitsInStock == 0);


            //////Query Exprestion
            ////var result = from P in ProductList
            ////             where P.UnitsInStock == 0
            ////             select P;

            ////var result = ProductList.Where(P => P.Category == "Mear/Poutry");

            ////var result = from P in ProductList
            ////             where P.Category == "Mear/Poutry"
            ////             select P;

            ////var result= ProductList.Where(P => P.UnitsInStock>0).Where(P => P.Category == "Mear/Poutry");
            ////var result= ProductList.Where(P => P.UnitsInStock>0 && P.Category == "Mear/Poutry");

            ////var result = from P in ProductList
            ////             where P.UnitsInStock > 0 && P.Category == "Mear/Poutry"
            ////             select P; 

            ////Indexed Where valid in fluent Syntax only
            ////Can't be written by Query syntax
            //var result = ProductList.Where((P, Index) => Index < 10 && P.UnitsInStock == 0);



            //ArrayList arraylist = new ArrayList() { 1, 2, 3, "Ahmed", "Ali", 1.3, 1.5, 1.7f, 1.8f, 2.3m, ProductList[0] };
            //var result= arraylist.OfType<int>();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region 2.Transformation Operators = Select / SelectMany
            //2.Transformation Operators = Select / SelectMany

            //Fluent Syntax
            //var result = ProductList.Select(P => P);
            //var result = ProductList.Select(P => P.ProductName);


            //var result = from P in ProductList
            //             select P.ProductName;


            //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Seafood")
            //                        .Select(P => new { 
            //                            P.ProductName , 
            //                            P.Category ,
            //                            OldPrice = P.UnitPrice , 
            //                            NewPrice = P.UnitPrice - P.UnitPrice * 0.1M});


            //var result = from P in ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Seafood"
            //             select (new
            //             {
            //                 P.ProductName,
            //                 P.Category,
            //                 OldPrice = P.UnitPrice,
            //                 NewPrice = P.UnitPrice - P.UnitPrice * 0.1M
            //             });

            //var result = CustomerList.Select(C => C.CustomerName);
            //var result = CustomerList.Select(C => C.Orders); // If one of the property is sequence
            //var result = CustomerList.SelectMany(C => C.Orders); // If one of the property is sequence

            //var result = from C in CustomerList
            //             from O in C.Orders
            //             select O;

            //Indexed Select Valid only in Fluent Syntax 
            //Can't Be Written in query syntax [Query Expression] 
            //var result = ProductList.Select((P, I) => new {I,P.ProductName }).Where(P => P.I < 5 );

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region 3.Oredering operator
            //3.Oredering operator

            //Sorting

            //var result = ProductList.OrderBy(P => P.UnitPrice);
            //var result = ProductList.OrderByDescending(P => P.UnitPrice).Select(P=> new {P.ProductName,P.UnitPrice,P.UnitsInStock });
            //var result = ProductList.OrderByDescending(P => P.UnitsInStock).Select(P=> new {P.ProductName,P.UnitPrice,P.UnitsInStock });



            //var result = ProductList.OrderByDescending(P => P.UnitPrice).Select(P=> new {P.ProductName,P.UnitPrice,P.UnitsInStock });
            //var result = ProductList.OrderBy(P => P.UnitsInStock).ThenBy(P=>P.UnitPrice).Select(P=> new {P.ProductName,P.UnitPrice,P.UnitsInStock });
            //var result = ProductList.Where(P=>P.Category=="Seafood").OrderBy(P => P.UnitsInStock).ThenBy(P=>P.UnitPrice).Select(P=> new {P.ProductName,P.UnitPrice,P.UnitsInStock });


            //var result = from P in ProductList
            //             where P.Category == "Seafood" && P.UnitsInStock > 0
            //             orderby P.UnitPrice, P.UnitsInStock descending
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.UnitPrice,
            //                 P.UnitsInStock
            //             };


            //var result= ProductList.Reverse<Product>();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //foreach (var item in ProductList)
            //{
            //    Console.WriteLine(item);
            //}  
            #endregion


            #region 4.Elements Operators = Immediate Execution 
            //4.Elements Operators = Immediate Execution 

            //ProductList = new List<Product>();

            //var result = ProductList.First();
            //Console.WriteLine(result); // May throw exception [sequence contain no element]

            //var result = ProductList.Last();
            //Console.WriteLine(result);

            //var result = ProductList.First(P => P.UnitsInStock == 1000);
            //var result = ProductList.Last(P => P.UnitsInStock == 0);

            //var result = ProductList.FirstOrDefault();
            //var result = ProductList.FirstOrDefault(new Product() {ProductName="Default Product" });
            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 1000);
            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 1000, new Product() { ProductName = "Default Product" });

            //var result = ProductList.LastOrDefault();
            //var result = ProductList.LastOrDefault(new Product() { ProductName = "Default Product" });
            //var result = ProductList.LastOrDefault(P => P.UnitsInStock == 1000);
            //var result = ProductList.LastOrDefault(P => P.UnitsInStock == 1000, new Product() { ProductName = "Default Product" });

            //var result = ProductList.ElementAt(0); //May Throw Exception
            //var result = ProductList.ElementAtOrDefault(1);

            //ProductList = new List<Product>() { new Product() { ProductName = "Only One  Product " } };

            //var result = ProductList.Single(); //May throw exception

            //var result = ProductList.Single(P=>P.UnitsInStock==1000);


            //var result = ProductList.Single(P=>P.UnitsInStock==0);

            //var result = ProductList.SingleOrDefault();

            //Console.WriteLine(result?.ProductName ?? "NA");

            //var result = ProductList.DefaultIfEmpty();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region 5.Aggregate Operator = Immediate Execution 
            //5.Aggregate Operator = Immediate Execution 
            //Count - Sum - Max -Min - Avg 

            //var result = ProductList.Count();//77
            //var result = ProductList.Count;//77

            //var result = ProductList.Count(P=>P.UnitsInStock == 0); //5

            //var result = ProductList.Where(P=>P.UnitsInStock == 0).Count(); //5

            //Sum
            //var result = ProductList.Sum(P => P.UnitPrice);
            //var result = ProductList.Sum(P=>P.UnitsInStock);

            //var result = ProductList.Average(P => P.UnitPrice);

            //Max
            //var result = ProductList.Max();
            //var result = ProductList.Max(new ProductComparerUnitInStock());
            //var result = ProductList.Max(P=>P.UnitPrice);
            //var result = ProductList.Max(P=>P.UnitsInStock);

            //var MaxResult = ProductList.Max(P => P.UnitsInStock);

            //var result = ProductList.Where(P => P.UnitsInStock == MaxResult);

            //var result = ProductList.MaxBy(P => P.UnitPrice);


            //Min
            //var result = ProductList.Min();
            //var result = ProductList.Min(new ProductComparerUnitInStock());
            //var result = ProductList.Min(new ProductComparerNameLength);
            //var result = ProductList.Min(new ProductComparerNameLength());

            //var result = ProductList.Min(P => P.UnitPrice);

            //var result = ProductList.MinBy(P => P.UnitPrice);


            //Aggregate

            //List<string> Names = new List<string>() { "Ahmed" , "Ali" ,"Omar", "Osama"};

            //var result = Names.Aggregate((S01, S02)=>$"{S01} {S02}");

            //Console.WriteLine(result); 
            #endregion


            #region 6.Casting Operators : Immediate Execution
            //6.Casting Operators : Immediate Execution

            //List<Product> list = ( List<Product>) ProductList.Where(P => P.UnitsInStock==0);//Invalid
            //List<Product> list = ProductList.Where(P => P.UnitsInStock==0).ToList();
            //Product [] list = ProductList.Where(P => P.UnitsInStock==0).ToArray();
            //Dictionary<long,Product>list = ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P => );

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region 7.Generation Operators
            //7.Generation Operators
            //The only Way to call this method as -> class member throught "Enumerable" Class

            //Range , Empty ,Reqeat

            //var result = Enumerable.Range(1, 100);

            //var result = Enumerable.Empty<Product>().ToList();

            //result.Add(new Product() {ProductName="P01" });
            //result.Add(new Product() {ProductName="P02" });


            //var result = Enumerable.Repeat( ProductList[0],3);
            //var result = Enumerable.Repeat( 1,3);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region 8.Set Operators - Union Family 
            ////8.Set Operators - Union Family 
            ////Union - Union All - Intersect - Execpt

            //var Seq01 = Enumerable.Range(1, 100);
            //var Seq02 = Enumerable.Range(50, 100);

            ////var result = Seq01.Union(Seq02); //Like Union IN SQL Without Duplication
            ////var result = Seq01.Concat(Seq02); //Like Union All IN SQL With Duplication



            ////result = result.Distinct(); //Remove Duplication

            ////var result = Seq01.Intersect(Seq02);
            ////var result = Seq02.Except(Seq01);

            //foreach (var item in Seq01)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 9.Quentifiers Operators - Return Boolean 
            //9.Quentifiers Operators - Return Boolean 

            //Any - All - SequenceEqual - contains

            //var Seq01 = Enumerable.Range(1, 100);
            //var Seq02 = Enumerable.Range(50, 100);


            //Any()--> Return True if there are at least one element [in sequence or match the conditions]

            //var result = Seq01.Any(N => N % 2 == 0);

            //ProductList = new List<Product>();

            //var result = ProductList.Any();
            //var result = ProductList.Any(P => P.UnitsInStock==0);

            //All()-->Return True if All Elements in the Sequence match the condition

            //var result = ProductList.All ( P => P.UnitsInStock == 0);
            //var result = ProductList.All ( P => P.UnitPrice > 0);

            //SequenceEqual()

            //var result = Seq01.SequenceEqual(Seq02);
            //var result = Seq01.Contains(1);

            //ProductList.Contains();

            //Console.WriteLine(result); 
            #endregion


            #region 10.Zippng Operator 
            //10.Zippng Operator 
            ////Zip 

            //List<string> words = new List<string>() { "Ten" , "Twenty","Thitry","Fourty"};

            //List<int> numbers = new List<int>() {10,20,30,40,50,60 };

            ////var result = words.Zip(numbers, (W, N) => $"{N}-->{W}");
            //var result = words.Zip(numbers, (W, N) => new { numbers = N , words =W });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


        }
    }
}
