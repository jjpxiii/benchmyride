using System.Text.RegularExpressions;

partial class Benchmark
{
    [GeneratedRegex(@"[\w\.+-]+@[\w\.-]+\.[\w\.-]+")]
    private static partial Regex Email();

    [GeneratedRegex(@"[\w]+://[^/\s?#]+[^\s?#]+(?:\?[^\s#]*)?(?:#[^\s]*)?")]
    private static partial Regex Uri();

    [GeneratedRegex(@"(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9])")]
    private static partial Regex IP();
    static void Main(string[] args)
    {
        StreamReader reader = new("../../assets/regexin.txt");
        string data = reader.ReadToEnd();

        // Email
        Console.WriteLine(Email().Matches(data).Count);
        Console.WriteLine(Uri().Matches(data).Count);
        Console.WriteLine(IP().Matches(data).Count);
    }

    static void Measure(string data, string pattern)
    {
        Console.WriteLine(Regex.Matches(data, pattern).Count);
    }
}