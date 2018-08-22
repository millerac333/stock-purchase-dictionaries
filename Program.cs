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

            string GM = stocks["GM"];
            string CAT = stocks["CAT"];
            string TSLA = stocks["TSLA"];
            string GOOG = stocks["GOOG"];
            string NKE = stocks["NKE"];

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GE", shares: 150, price: 23.21));
            purchases.Add((ticker: "GE", shares: 32, price: 17.87));
            purchases.Add((ticker: "GE", shares: 80, price: 19.02));

            purchases.Add((ticker: "CAT", shares: 100, price: 23.21));
            purchases.Add((ticker: "CAT", shares: 50, price: 17.87));
            purchases.Add((ticker: "CAT", shares: 25, price: 19.02));

            purchases.Add((ticker: "TSLA", shares: 333, price: 23.21));
            purchases.Add((ticker: "TSLA", shares: 33, price: 17.87));
            purchases.Add((ticker: "TSLA", shares: 3, price: 19.02));

            purchases.Add((ticker: "GOOG", shares: 99, price: 23.21));
            purchases.Add((ticker: "GOOG", shares: 56, price: 17.87));
            purchases.Add((ticker: "GOOG", shares: 33, price: 19.02));

            purchases.Add((ticker: "NKE", shares: 100, price: 23.21));
            purchases.Add((ticker: "NKE", shares: 200, price: 17.87));
            purchases.Add((ticker: "NKE", shares: 25, price: 19.02));

            // Create a total ownership report that computes the total value of each stock that you have purchased. This is the basic relational database join algorithm between two tables.

        }
    }
}
