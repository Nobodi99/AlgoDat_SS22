// See https://aka.ms/new-console-template for more information

using Algorithms;

Console.WriteLine("Testprogramm für AlgoDat\n");

Console.WriteLine("Sorting:");

var test = new[] { 13, 19, 9, 5, 12, 8, 7, 4, 11, 2, 6, 21 };


Console.WriteLine(
QuickSort.HoarePartition(test, 0, 11));

//Helper.PrintArray(test);