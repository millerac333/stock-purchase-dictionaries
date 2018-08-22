using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("TSLA", "Tesla");
            stocks.Add("GOOG", "Google");
            stocks.Add("NKE", "Nike");
        }
    }
}
