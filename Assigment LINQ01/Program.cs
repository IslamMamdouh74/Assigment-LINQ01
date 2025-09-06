using Assigment_LINQ01;
using Assigment_LINQ01.Data;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
namespace Assigment_LINQ01
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region  LINQ - Restriction Operators

            #region Q01
            //1.Find all products that are out of stock.
            //1 - Fluent
            //var Result = ProductList.where(P => P.UnitsInStock == 0);
            ////02 Dynamic
            //Result = from e in ProductList
            //         where e.UnitsInStock == 0
            //         select e;
            //foreach (var Unit in Result)
            //{
            //    Console.WriteLine(Result);
            //}
            #endregion
            #region Q02
            //2. Find all products that are in stock and cost more than 3.00 per unit.
            //var Result = ProductList.where(P => P.UnitsInStock > 0 && P.UnitPrice > 300m);

            //Result=from e in ProductList 
            //       where e.UnitsInStock > 0 && e.UnitPrice >300m
            //       select e;
            //foreach (var Unit in Result)
            //{
            //    Console.WriteLine(Result);
            //}
            #endregion
            #region Q03
            //3. Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result = Arr.Select((name, Index) => new { name, Index })
            //    .Where(x => x.name.Length < x.Index)
            //    .Select(x => x.name);
            //foreach (var x in Result)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion
            #endregion
            #region LINQ - Element Operators
            #region Q01
            //1. Get first Product out of Stock
            //var Result = ProductList.First(P => P.UnitOfProduct == 0);

            //Result=from e in ProductList
            //       where e.UnitOfProduct == 0
            //       select e.First;
            #endregion
            #region Q02
            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var Result = ProductList.FirstOrDefult(P => P.UnitOfPrice > 1000);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q03
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result= Arr.Where(N=>N>5).Skip(1).FirstOrDefult();
            //foreach(int N in Arr)
            //{
            //    Console.WriteLine(N);
            //}





            #endregion
            #endregion
            #region LINQ - Aggregate Operators
            #region Q01
            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            // var Result = Arr.Count(n => n % 2 == 1);
            //foreach (int n in Arr)
            // {
            //     Console.WriteLine(n);
            // }
            #endregion
            #region Q02
            //var result = customersList.Select(c => new Customer = OrderCount = c.Orders.Count()});

            #endregion
            #region Q03
            //var Result = productList.GroupBy(p => p.Category).Select(g => new Category = g.Key, ProductCount = g.Count() });
            #endregion
            #region Q04
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result=Arr.Sum(x => x);
            //foreach(int i in Result)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion
            #region Q05,06,07,08
            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //05 var Result=words.Sum(W=>W.Length);
            //06  var Result= words.Min(x => x.Length);
            //07 var Result = words.Max(x => x.Length);
            //08 var Result = words.Average(x => x.Length);


            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion
            #region  LINQ - Ordering Operators
            #region Q01
            //var Result = ProductList.OrderBy(P => P.ProductName);
            //Console.WriteLine(Result);
            #endregion
            #region Q02
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result=Arr.OrderBy(A=>A,StringComparer.OrdinalIgnoreCase);
            //Console.WriteLine(Result);  
            #endregion
            #region Q03
            //var Result = ProductList.OrderByDescending(p => p.UnitOfStock);
            //Console.WriteLine(Result);
            #endregion
            #region Q04
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var Result= Arr.OrderBy(x=>x.Length).ThenBy(x=>x);
            //Console.WriteLine(Result);
            #endregion
            #region Q05
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(x=>x.Length).ThenBy(x=>x,StringComparer.OrdinalIgnoreCase);
            //Console.WriteLine(Result);
            #endregion
            #region Q06
            //var Result =ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //Console.WriteLine(Result);
            #endregion
            #region Q07
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result=Arr.OrderBy(x=>x.Length).ThenByDescending(x=>x,StringComparer.OrdinalIgnoreCase);
            //Console.WriteLine(Result);
            #endregion
            #region 08
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var Result=Arr.Where(x => x.Length>1 && x[1]=='i').Reverse();
            //Console.WriteLine(Result);

            #endregion
            #endregion
            #endregion
            #region  LINQ – Transformation Operators
            #region Q01,02,03,04,05,06,07
            //01
            //var Result = ProductList.Select(P => P.ProductName);

            // 02
            // String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var Result=words.Select(W=>new {Upper=W.ToUpper(),Lower=W.ToLower()});

            //03
            //var Result= ProductList.Select(P => new {P.Name,Price=P.Price});
            //Console.WriteLine(Result);

            //04
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Select((value, Index) => new { value, Index }).Where(n => n.value == n.Index).Select(n => n.value);
            //Console.WriteLine(Result);

            //05
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var Result = numbersB.SelectMany(n => numbersB, (a, b) => new { a, b }).Where(pair => pair.a < pair.b);
            //foreach (var pair in Result)
            //{
            //    Console.WriteLine(pair);
            //}

            //06
            //var Result = OrderList.where(O => O.TotalOfOrder < 500m);

            //07
            //var Result = OrderList.Where(o => o.OrderDate.Year >= 1998);
            //Console.WriteLine(Result);












            //Console.WriteLine(Result);

            #endregion
            #endregion


        }
    }
}
