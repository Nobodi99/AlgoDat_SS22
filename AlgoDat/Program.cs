// See https://aka.ms/new-console-template for more information

using Algorithms;

Console.WriteLine("Testprogramm für AlgoDat\n");

Console.WriteLine("BubbleSort:");

var test = new[] { 35, 22, 10, 51, 48 };

BubbleSort bubble = new BubbleSort();

PrintArray(bubble.Sort(test));

void PrintArray(int[] input)
{
    for (int i = 0; i < input.Length - 1; i++)
    {
        Console.Write($"{input[i]} ");
    }
    Console.WriteLine(input[^1]);
}