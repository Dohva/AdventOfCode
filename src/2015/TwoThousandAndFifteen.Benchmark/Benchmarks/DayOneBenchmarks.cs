using BenchmarkDotNet.Attributes;
using TwoThousandAndFifteen.Console.Apps;
using TwoThousandAndFifteen.Lib.DayOne.Implementations;

namespace TwoThousandAndFifteen.Benchmark.Benchmarks;

public class DayOneBenchmarks
{
    private readonly string PuzzleInput = new DayOneResult().PuzzleInput;
    private readonly DayOneSolution _solver = new DayOneSolution();

    [Benchmark(Baseline = true)]
    public int ForLoop() => _solver.PartOne(PuzzleInput);
}