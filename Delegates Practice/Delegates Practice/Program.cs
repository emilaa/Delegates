using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates_Practice
{
    class Program
    {
        #region Delegates
        //public delegate bool CheckNums(int num);

        //public delegate void ChangeString(string str);

        //public delegate int StringLength(string str, int m);
        #endregion

        static void Main(string[] args)
        {
            #region Predicate, Action
            //int[] arr = { 1, 2, 3, 4, 5, 6 };

            //Console.WriteLine(Sum(CheckOdd, arr));

            //Console.WriteLine(Sum(CheckEven, arr));

            //Console.WriteLine(Sum(CheckMoreThanFive, arr));

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = numbers.FindAll(m => m > 6 && m < 9);

            //var result2 = numbers.FindAll(CheckMoreThanFive);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Test(StringToUpper, "Cavid");

            //string name = "Emil";

            //String str = ("Emil");

            //Console.WriteLine(str);

            //ChangeString change = StringToUpper;

            //change += StringToLower;
            //change += delegate (string s)
            //{
            //    Console.WriteLine(s.ToLower());
            //};

            //change += s => Console.WriteLine(s.ToLower());

            //change("Orxan");

            //Action<string, int, string> action = StringToUpper;

            //action += StringToLower;

            //action("Orxan", 55, "-P130");
            #endregion

            #region Function
            //Console.WriteLine(Test(StrLength, "Mirsamir", 5));

            //Func<string, int, string> func = StrLength;

            //Func<string, int, int> func2 = StrLength2;

            //Console.WriteLine(func("Emil", 20));
            #endregion
        }
        
        #region Delegates, Predicate, Action, Function
        //public static void Test() => Console.WriteLine("Tested");

        //public static string StrLength(string str, int m)
        //{
        //    return str.Length.ToString() + "-Age:" + m;
        //}

        //public static int StrLength2(string str, int m)
        //{
        //    return str.Length + m;
        //}

        ////public static int Test(StringLength func, string str, int m)
        ////{
        ////    return func(str, m);
        ////}

        //public static void StringToUpper(string str, int n, string t)
        //{
        //    Console.WriteLine(str.ToUpper() + "-" + n + t);
        //}

        //public static void StringToLower(string str, int n, string t)
        //{
        //    Console.WriteLine(str.ToLower() + "-" +n + t);
        //}

        //public static void Test(ChangeString func, string str)
        //{
        //    func(str);
        //}

        //public static bool CheckOdd(int number)
        //{
        //    return number % 2 != 0;
        //}

        //public static bool CheckEven(int number)
        //{
        //    return number % 2 == 0;
        //}

        //public static bool CheckMoreThanFive(int number)
        //{
        //    return number > 6;
        //}

        //public static int Sum(Predicate<int> predicate, int[] nums)
        //{
        //    var sum = 0;

        //    foreach (var item in nums)
        //    {
        //        if (predicate(item))
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}

        //public static int SumEven(CheckNums func, int[] nums)
        //{
        //    var sum = 0;

        //    foreach (var item in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}

        //public static int SumMoreThanFive(int[] nums)
        //{
        //    var sum = 0;

        //    foreach (var item in nums)
        //    {
        //        if (item > 5)
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}
        #endregion
    }
}
