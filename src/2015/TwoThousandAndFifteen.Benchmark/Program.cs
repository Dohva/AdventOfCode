
using BenchmarkDotNet.Running;
using TwoThousandAndFifteen.Benchmark.Benchmarks;

var summary = BenchmarkRunner.Run<DayOneBenchmarks>();