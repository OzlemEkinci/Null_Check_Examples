using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullCheckExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Null-coalescing operator (??)
            string name1 = null;
            string result1 = name1 ?? "Default Value";
            Console.WriteLine($"Result of ?? operator: {result1}");

            // 2. Null-coalescing assignment (??=)
            // 8.0 ve üzerinde kullanılmaktadır
            //string name2 = null;
            //name2 ??= "Assigned Value";
            //Console.WriteLine($"Result of ??= operator: {name2}");

            // 3. Null-conditional operator (?.)
            string name3 = null;
            int? length3 = name3?.Length;
            Console.WriteLine($"Result of ?. operator: {length3}");

            // 4. Null-forgiving operator (!)
            // 8.0 ve üzerinde kullanılmaktadır
            //string? name4 = "NotNullValue";
            //int length4 = name4!.Length; // name4 is not null, safe to use '!'
            //Console.WriteLine($"Result of ! operator: {length4}");

            // 5. Pattern matching (is)
            object obj = "Hello Pattern Matching";
            if (obj is string name5)
            {
                Console.WriteLine($"Pattern matching result: {name5}");
            }

            // 6. is not null (C# 9.0+)
            //string name6 = "C# 9 Not Null";
            //if (name6 is not null)
            //{
            //    Console.WriteLine($"Result of is not null: {name6}");
            //}

            Console.ReadLine();
        }
    }
}
