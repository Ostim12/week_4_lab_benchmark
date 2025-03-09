using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


int result;

result = AlgoDS.Searching.LinearSearch.IntLinearSearch([4, 6, 8, 10], 8);
Console.WriteLine(result);
result = 0;
result = AlgoDS.Searching.LinearSearch<int>.Search([4, 6, 8, 10], 8);
Console.WriteLine(result);

result = AlgoDS.Searching.BinarySearch.IntBinarySearch([4, 6, 8, 10], 8);
Console.WriteLine(result);

result = AlgoDS.Searching.BinarySearch<string>.Search(["a","b", "c", "d"], "b");
Console.WriteLine(result);

BenchmarkRunner.Run<MyBenchmark>();


[MemoryDiagnoser] // Shows memory usage in benchmark results
[SimpleJob(iterationCount: 10)] // Runs 10 iterations

public class MyBenchmark
{

    private int[] dataArray;
    private List<int> dataList;

    private const int DataSize = 10000;

    [GlobalSetup]

    public void Setup()
    {
        var random = new Random(42);

        dataArray = new int[DataSize];
        for (int i = 0; i < DataSize; i++)
        {
            dataArray[i] = random.Next();
        }

        dataList = new List<int>(dataArray);
    }

    [Benchmark]
    public void Do()
    {
        AlgoDS.DataStructures.Queue q = new AlgoDS.DataStructures.Queue();
    }
    [Benchmark]
    public int[] ArraySort()
    {
        var cloned = (int[])dataArray.Clone();
        Array.Sort(cloned);
        return cloned;
    }

    [Benchmark]
    public List<int> ListSort()
    {
        var cloned = new List<int>(dataList);
        cloned.Sort();
        return cloned;
    }
}
