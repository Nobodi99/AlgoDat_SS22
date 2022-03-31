// See https://aka.ms/new-console-template for more information

using Algorithms;

int[] testArray = new int[] { 3, 41, 52, 26, 38, 57, 9, 49 };

MergeSort ms = new MergeSort();

var result = ms.Sort(testArray);

foreach (var i in result)
{
    Console.Write($"{i} ");
}