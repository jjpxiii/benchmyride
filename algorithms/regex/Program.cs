using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

class Benchmark
{
    static void Main(string[] args)
    {
        StreamReader reader = new System.IO.StreamReader("../../assets/regexin.txt");
        string data = reader.ReadToEnd();

        // Email
        Benchmark.Measure(data, @"[\w\.+-]+@[\w\.-]+\.[\w\.-]+");

        // URI
        Benchmark.Measure(data, @"[\w]+://[^/\s?#]+[^\s?#]+(?:\?[^\s#]*)?(?:#[^\s]*)?");

        // IP
        Benchmark.Measure(data, @"(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])");
    }

    static void Measure(string data, string pattern)
    {
        Console.WriteLine(Regex.Matches(data, pattern).Count);
    }
}