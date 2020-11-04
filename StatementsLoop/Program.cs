using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace StatementsLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Enumerable.Range(0, 10000000).ToArray();
            var list = Enumerable.Range(0, 10000000).ToList();
            
            Console.WriteLine(ArrayForWithoutCacheLength(array));
            Console.WriteLine(ArrayForWithCacheLength(array));
            Console.WriteLine(ArrayForeach(array));
            Console.WriteLine(ArrayForEach(array));
            
            Console.WriteLine(ListForWithoutCacheLength(list));
            Console.WriteLine(ListForWithCacheLength(list));
            Console.WriteLine(ListForeach(list));
            Console.WriteLine(ListForEach(list));
     
            Console.ReadKey();
        }
        
           static double ArrayForWithoutCacheLength(int[] array)
        {
            int result = 0;

            var watch = Stopwatch.StartNew();

            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }

            watch.Stop();

            return watch.Elapsed.TotalMilliseconds;
        }

        static double ArrayForWithCacheLength(int[] array)
        {
            int length = array.Length;
            int result = 0;

            var watch = Stopwatch.StartNew();

            for (int i = 0; i < length; i++)
            {
                result += array[i];
            }

            watch.Stop();

            return watch.Elapsed.TotalMilliseconds;
        }

        static double ArrayForeach(int[] array)
        {
            int result = 0;

            var watch = Stopwatch.StartNew();

            foreach (var item in array)
            {
                result += item;
            }

            watch.Stop();

            return watch.Elapsed.TotalMilliseconds;
        }

        static double ArrayForEach(int[] array)
        {
            int result = 0;

            var watch = Stopwatch.StartNew();

            Array.ForEach(array, i => { result += i; });

            watch.Stop();

            return watch.Elapsed.TotalMilliseconds;
        }

        static double ListForWithoutCacheLength(List<int> list)
        {
            int result = 0;

            var watch = Stopwatch.StartNew();

            for (int i = 0; i < list.Count; i++)
            {
                result += list[i];
            }

            watch.Stop();

            return watch.Elapsed.TotalMilliseconds;
        }

        static double ListForWithCacheLength(List<int> list)
        {
            int count = list.Count;
            int result = 0;

            var watch = Stopwatch.StartNew();

            for (int i = 0; i < count; i++)
            {
                result += list[i];
            }

            watch.Stop();

            return watch.Elapsed.TotalMilliseconds;
        }

        static double ListForeach(List<int> list)
        {
            int result = 0;

            var watch = Stopwatch.StartNew();

            foreach (var item in list)
            {
                result += item;
            }

            watch.Stop();

            return watch.Elapsed.TotalMilliseconds;
        }

        static double ListForEach(List<int> list)
        {
            int result = 0;

            var watch = Stopwatch.StartNew();

            list.ForEach(i => { result += i; });

            watch.Stop();

            return watch.Elapsed.TotalMilliseconds;
        }
    }
}