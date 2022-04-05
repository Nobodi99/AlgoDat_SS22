// See https://aka.ms/new-console-template for more information

using Algorithms;

Console.WriteLine("Testprogramm für AlgoDat\n");

Console.WriteLine("BubbleSort:");

var test = new[] { 55, 25, 89, 34, 12, 19, 78, 95, 1, 100 };

HeapSort heap = new HeapSort();

heap.Sort(test);

PrintArray(test);

void PrintArray(int[] input)
{
    for (int i = 0; i < input.Length - 1; i++)
    {
        Console.Write($"{input[i]} ");
    }
    Console.WriteLine(input[^1]);
}