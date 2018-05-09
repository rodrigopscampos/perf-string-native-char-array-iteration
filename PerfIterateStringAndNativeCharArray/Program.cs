using System;
using System.Diagnostics;

namespace PerfIterateStringAndNativeCharArray
{
    class Program
    {
        unsafe static void Main()
        {
            if (Stopwatch.IsHighResolution)
                Console.WriteLine("Operations timed using the system's high-resolution performance counter.");
            else
                Console.WriteLine("Operations timed using the DateTime class.");

            Console.WriteLine("Timer frequency in ticks per second = {0}", Stopwatch.Frequency);

            var nanosecPerTick = (1000L * 1000L * 1000L) / Stopwatch.Frequency;
            Console.WriteLine("Timer is accurate within {0} nanoseconds", nanosecPerTick);

            Console.WriteLine();

            var charArray = new char[100 * 1024 * 1024];
            var charArrayLength = charArray.Length;

            var str = new string(charArray);
            var strLength = str.Length;

            Console.WriteLine("String size: " + strLength + " Bytes");
            Console.WriteLine("Result Scale: Milliseconds");

            Console.WriteLine();

            while (true)
            {
                var sw = new Stopwatch();

                sw = Stopwatch.StartNew();
                for (int i = 0; i < strLength; i++) { var c = str[i]; }
                sw.Stop();
                Console.WriteLine("Run over string using for: " + sw.ElapsedMilliseconds);

                sw = Stopwatch.StartNew();
                foreach (var c in str) { var cc = c; }
                sw.Stop();
                Console.WriteLine("Run over string using foreach: " + sw.ElapsedMilliseconds);


                sw = Stopwatch.StartNew();
                for (int i = 0; i < charArrayLength; i++) { var c = charArray[i]; }
                sw.Stop();
                Console.WriteLine("Run over char array using for: " + sw.ElapsedMilliseconds);

                sw = Stopwatch.StartNew();
                foreach (var c in charArray) { var cc = c; }
                sw.Stop();
                Console.WriteLine("Run over char array using foreach: " + sw.ElapsedMilliseconds);

                sw = Stopwatch.StartNew();
                fixed (char* pwzChars = &charArray[0])
                    for (int i = 0; i < charArrayLength; i++) { var c = pwzChars[i]; }
                sw.Stop();

                Console.WriteLine("Run over char array using pointer and copy: " + sw.ElapsedMilliseconds);

                sw = Stopwatch.StartNew();
                fixed (char* pwzChars = &charArray[0])
                    for (int i = 0; i < charArrayLength; i++) { var c = &pwzChars[i]; }
                sw.Stop();

                Console.WriteLine("Run over char array using pointer and referece: " + sw.ElapsedMilliseconds);

                Console.ReadLine();
                Console.WriteLine("---------------------------");
            }
        }
    }
}
