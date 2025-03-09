```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5487/22H2/2022Update)
Intel Core i7-10610U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  Job-GEJYHC : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

IterationCount=10  

```
| Method    | Mean     | Error    | StdDev   | Gen0   | Allocated |
|---------- |---------:|---------:|---------:|-------:|----------:|
| ArraySort | 495.3 μs | 60.16 μs | 39.79 μs | 9.2773 |  39.09 KB |
| ListSort  | 479.9 μs | 36.72 μs | 21.85 μs | 8.7891 |  39.12 KB |
