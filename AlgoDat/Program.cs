// See https://aka.ms/new-console-template for more information

using Algorithms;

Console.WriteLine("Testprogramm für AlgoDat\n");

Console.WriteLine("BubbleSort:");

var test = new[] { 27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0 };

HeapSort heap = new HeapSort();

//heap.Sort(test);

heap.MaxHeapify(test, 2, test.Length);