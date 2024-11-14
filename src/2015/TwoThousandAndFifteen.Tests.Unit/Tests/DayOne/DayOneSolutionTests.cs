using TwoThousandAndFifteen.Lib.DayOne;
using TwoThousandAndFifteen.Lib.DayOne.Implementations;
using FluentAssertions;

namespace TwoThousandAndFifteen.Tests.Unit.Tests.DayOne;

public class DayOneSolutionTests
{
     private readonly IDayOneSolution _sut;

     public DayOneSolutionTests()
     {
          _sut = new DayOneSolution();
     }
     [Theory]
     [InlineData("(())", 0)]
     [InlineData("()()", 0)]
     [InlineData("(((", 3)]
     [InlineData("(()(()(", 3)]
     [InlineData("))(((((", 3)]
     [InlineData("())", -1)]
     [InlineData("))(", -1)]
     [InlineData(")))", -3)]
     [InlineData(")())())", -3)]
     public void PartOne_ShouldReturnSolution_GivenSomeInput(string input, int expected)
     {
          var result = _sut.PartOne(input);

          result.Should().Be(expected);
     }

     [Theory]
     [InlineData(")", 1)]
     [InlineData("()())", 5)]
     public void PartTwo_ShouldReturnSolution_GivenSomeInput(string input, int expected)
     {
          var result = _sut.PartTwo(input);

          result.Should().Be(expected);
     }
     
}