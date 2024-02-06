using System.Text.Json;

var text = File.ReadAllText(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..", "10mil.json")));
var arr = JsonSerializer.Deserialize<int[]>(text);
Array.Sort(arr!);
Console.WriteLine(arr![666]);
Console.WriteLine(arr![666666]);
