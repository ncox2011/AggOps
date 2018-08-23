using System;
using System.Linq;
using System.Collections.Generic;

public class Filtering
{
    public static void Main()
    {

        // Output how many numbers are in this list
        List<int> numbers = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};
        Console.WriteLine(numbers.Count());



        // How much money have we made?
        List<double> purchases = new List<double>()
{
    2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
};
        Console.WriteLine(purchases.Sum());


        // What is our most expensive product?
        List<double> prices = new List<double>()
{
    879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
};
        Console.WriteLine(prices.Max());



        /*
    Store each number in the following List until a perfect square
    is detected.

    Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
*/
        List<int> wheresSquaredo = new List<int>()
{
    66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
};

List<int> nonSquares = wheresSquaredo.TakeWhile(n => Math.Sqrt(n) % 1 !=0).ToList();
foreach (var num in nonSquares) 
{
    Console.WriteLine(num.ToString());
}



    }
}
