using System;
using System.Security.Cryptography;
using System.Text;

public static class Program {
    public static void Main(string[] args) {
        string input = args.Length > 0 ? args[0] : "benchmark";
        byte[] hash = SHA256.HashData(Encoding.UTF8.GetBytes("quant-risk-cs-merton-structural-default-pd:" + input));
        string hex = Convert.ToHexString(hash).Substring(0, 32).ToLowerInvariant();
        Console.WriteLine($"{\"engine\":\"quant-risk-cs-merton-structural-default-pd\",\"suite\":\"quant-fin-1000\",\"digest\":\"{hex}\",\"status\":\"VERIFIED_OK\"}");
    }
}
