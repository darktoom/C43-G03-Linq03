
using System.ComponentModel.DataAnnotations;
using static C43_G03_Linq03.ListGenerator;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace C43_G03_Linq03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region quantifier operator
            //var result = ProductList.Any();
            //result=ProductList.Any(x => x.UnitsInStock == 0);
            //result=ProductList.Any(x => x.UnitsInStock ==1 );
            //result=ProductList.All(x => x.UnitsInStock==0);
            //var seq1 = Enumerable.Range(0, 100);
            //var seq2 = Enumerable.Range(50, 150);
            //result=seq1.SequenceEqual(seq2);
            //Console.WriteLine(  result);


            #endregion

            #region zip operator
            //string[] names = { "omar", "amr", "ahmed", "may", "attta" };
            //int[] num = Enumerable.Range(0, 10).ToArray();
            //char[] chars = { 'a', 'b', 'c', 'd' };
            // var res = names.Zip(num,chars);
            //var result= names.Zip(num, (name, number) => new {index=number,name=name });


            //foreach (var c in result)
            //{

            //    Console.WriteLine(c);

            //}

            #endregion

            #region grouping operator
            //var result = from p in ProductList
            //             group p by p.Category;
            //foreach (var item in result) {
            //    Console.WriteLine(item.Key);
            //    foreach (var item2 in item) {

            //        Console.WriteLine(item2.ProductName);

            //    }



            //}

            // var result = ProductList.Where(p => p.UnitsInStock > 0).GroupBy(p=>p.Category);
            //  var result= ProductList.Where(p=>p.UnitsInStock>0).GroupBy(p=>p.Category).Where(p=>p.Count() >10) ;
            //var result=from p in ProductList
            //           where p.UnitsInStock > 0
            //           group p by p.Category
            //           into category
            //           where category.Count() > 10
            //           select category;


            //var result = ProductList.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category).Where(p => p.Count() > 10).Select(x=> new {categoryname=x.Key,
            //count=x.Count()});



            //foreach (var item in result) {

            //    Console.WriteLine(item);
            //}

            //foreach (var item in result) {

            //    Console.WriteLine($"{item.Key}");
            //    foreach (var car in item) {

            //        Console.WriteLine($"                {car.ProductName}");

            //    }
            //}


            #endregion


            #region Partitioning operators

            //var result = ProductList.Take(75).Where(p=>p.UnitsInStock==0);
            //result = ProductList.TakeLast(10);
            //result = ProductList.Where(p => p.UnitsInStock==0).Skip(2);
            //result = ProductList.Where(p => p.UnitsInStock == 0).SkipLast(2);
            //int[] arr = {1,2,3,4,5,6,7,8,9,0 };
            //var result=arr.TakeWhile(p => p <9);
            //result = arr.TakeWhile((num, i) =>  num>i);
            //result = arr.SkipWhile(a => a % 3 == 0);
            //foreach (var item in result) {
            //    Console.WriteLine(item);
            //}

            #endregion


            #region let into operators [only query syntax]
            //List<string> names= new List<string>() {"ahmed","mohmmed","tarek","hatem" };
            //            var result = from n in names
            //                         select Regex.Replace(n,"[aouieAOUIE]",string.Empty)
            //                         into nvl 
            //                         where nvl.Length>3
            //                         select nvl;

            //            result = from n in names
            //                     let nvl= Regex.Replace(n, "[aouieAOUIE]", string.Empty)
            //                     where nvl.Length>3
            //                     select nvl;    
            //foreach (var item in result) {

            //                Console.WriteLine( item);

            //            }

            #endregion


            #region assignment

            //var result =CustomerList.Take(3).Where(c=>c.City== "Washington").SelectMany(c=>c.Order).ToList();

            //var result =CustomerList.skip(2).Where(c=>c.City== "Washington").SelectMany(c=>c.Order).ToList();

            //foreach (var item in result) {
            //    Console.WriteLine(item);

            //}

            //int [] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((num, i) => num > i);

            //result = numbers.TakeWhile(num => num % 3 == 0);
            //result = numbers.TakeWhile((num, i) => num < i);

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var result=numbers.GroupBy(x => x%5);

            //foreach (var item in result) {
            //    Console.WriteLine(item);
            //}
             
            #endregion


        }
    }
}
