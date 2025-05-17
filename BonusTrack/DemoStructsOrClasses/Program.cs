// See https://aka.ms/new-console-template for more information
using DemoStructsOrClasses;

Console.WriteLine("Structs or Classes!");
//Code from https://www.mdft.academy/blog/whats-faster-in-csharp-a-struct-or-a-class

var benchmark = new Benchmark();

var stopwatch = new System.Diagnostics.Stopwatch();
stopwatch.Start();

benchmark.MeasureTestA();

stopwatch.Stop();


Console.WriteLine($"Test A: {stopwatch.Elapsed}");

stopwatch.Start();

benchmark.MeasureTestB();

stopwatch.Stop();

Console.WriteLine($"Test B: {stopwatch.Elapsed}");


stopwatch.Start();

benchmark.MeasureTestC();

stopwatch.Stop();

benchmark.Equals(stopwatch.Elapsed);

Console.WriteLine($"Test C: {stopwatch.Elapsed}");