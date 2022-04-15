// See https://aka.ms/new-console-template for more information

using Algorithms;

Console.WriteLine("Testprogramm für AlgoDat\n");

Console.WriteLine("Sorting:");

var test = new[] { 13, 19, 9, 5, 12, 8, 7, 4, 21, 2, 6, 11 };


QuickSort.Sort(test,0,test.Length-1);

Helper.PrintArray(test);