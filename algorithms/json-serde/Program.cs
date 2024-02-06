using System;
using System.Dynamic;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

static class Program
{
    public static async Task Main(string[] args)
    {
        var jsonStr = await File.ReadAllTextAsync($"canada.json", Encoding.UTF8).ConfigureAwait(false);
        var data = JsonSerializer.Deserialize<object>(jsonStr);
        // Console.WriteLine(data);
        PrintHash(JsonSerializer.Serialize(data));
        var list = new List<object>(13);
        for (var i = 0; i < 13; i++)
        {
            list.Add(JsonSerializer.Deserialize<object>(jsonStr)!);
        }
        PrintHash(JsonSerializer.Serialize(list));
    }

    private static void PrintHash(string s)
    {
        using var hasher = MD5.Create();
        var hash = hasher.ComputeHash(Encoding.UTF8.GetBytes(s));
        Console.WriteLine(ToHexString(hash));
    }

    static string ToHexString(byte[] ba)
    {
        StringBuilder hex = new StringBuilder(ba.Length * 2);
        foreach (byte b in ba)
            hex.AppendFormat("{0:x2}", b);
        return hex.ToString();
    }
}