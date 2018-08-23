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

            //("GM", 150, 23.21),;
            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            //("GM", 32, 17.87),;
            purchases.Add((ticker: "GM", shares: 32, price: 17.87));
            //("CAT", GM, 19.02),;
            purchases.Add((ticker: "GM", shares: 80, price: 19.02));

            //("CAT", 100, 23.21),;
            purchases.Add((ticker: "CAT", shares: 100, price: 23.21));
            //("CAT", 50, 17.87),;
            purchases.Add((ticker: "CAT", shares: 50, price: 17.87));
            //("CAT", 25, 19.02),;
            purchases.Add((ticker: "CAT", shares: 25, price: 19.02));

            //("TSLA", 333, 23.21),;
            purchases.Add((ticker: "TSLA", shares: 333, price: 23.21));
            //("TSLA", 33, 17.87),;
            purchases.Add((ticker: "TSLA", shares: 33, price: 17.87));
            //("TSLA", 3, 19.02),;
            purchases.Add((ticker: "TSLA", shares: 3, price: 19.02));

            //("GOOG", 99, 23.21),;
            purchases.Add((ticker: "GOOG", shares: 99, price: 23.21));
            //("GOOG", 56, 17.87),;
            purchases.Add((ticker: "GOOG", shares: 56, price: 17.87));
            //("GOOG", 33, 19.02),;
            purchases.Add((ticker: "GOOG", shares: 33, price: 19.02));

            //("NKE", 100, 23.21),;
            purchases.Add((ticker: "NKE", shares: 100, price: 23.21));
            //("NKE", 200, 17.87),;
            purchases.Add((ticker: "NKE", shares: 200, price: 17.87));
            //("NKE", 25, 19.02),;
            purchases.Add((ticker: "NKE", shares: 25, price: 19.02));

            // Create a total ownership report that computes the total value of each stock that you have purchased. This is the basic relational database join algorithm between two tables.

            /*
            Define a new Dictionary to hold the aggregated purchase information.
            - The key should be a string that is the full company name.
            - The value will be the valuation of each stock (price*amount)

            {
            "General Electric": 35900,
            "AAPL": 8445,
            ...
            }
            */
            Dictionary<string, double> Portfolio = new Dictionary<string, double>();
            //  { "General Electric", "Catapiller", "Tesla", "Google", "Nike" };

            // Iterate over the purchases and update the valuation for each stock
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                // Does the company name key already exist in the report dictionary?
                string fullCompanyName = stocks[purchase.ticker];
                if (Portfolio.ContainsKey(fullCompanyName))
                {
                    // If it does, update the total valuation
                    Portfolio[fullCompanyName] += purchase.shares * purchase.price;
                }
                else
                {
                    // If not, add the new key and set its value
                    Portfolio[fullCompanyName] = purchase.shares * purchase.price;
                }

            }
            foreach (KeyValuePair<string, double> stock in Portfolio)
            {
                Console.WriteLine($"I own {stock.Key} stock for a total of {stock.Value.ToString("C")}");
            }
        }
    }
}

