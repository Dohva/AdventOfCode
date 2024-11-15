using TwoThousandAndFifteen.Lib.DayOne;
using TwoThousandAndFifteen.Lib.DayOne.Implementations;
using FluentAssertions;

namespace TwoThousandAndFifteen.Tests.Unit.Tests.DayOne;

public class DayOneSolutionTests
{
     private readonly DayOneSolution _sut;

     public DayOneSolutionTests()
     {
          _sut = new DayOneSolution();
     }
     [Theory]
     [MemberData(nameof(PartOneData))] 
     public void PartOne_ShouldReturnSolution_GivenSomeInput(string input, int expected)
     {
          var result = _sut.PartOne(input);

          result.Should().Be(expected);
     }
     
     [Theory]
     [MemberData(nameof(PartOneData))]
     public void PartOneSelect_ShouldReturnSolution_GivenSomeInput(string input, int expected)
     {
          var result = _sut.PartOneSelect(input);

          result.Should().Be(expected);
     }
     
     [Theory]
     [MemberData(nameof(PartOneData))]
     public void PartOneGPTAggregate_ShouldReturnSolution_GivenSomeInput(string input, int expected)
     {
          var result = _sut.PartOneGPTAggregate(input);

          result.Should().Be(expected);
     }
     
     [Theory]
     [MemberData(nameof(PartOneData))]
     public void PartOneGPTSpan_ShouldReturnSolution_GivenSomeInput(string input, int expected)
     {
          var result = _sut.PartOneGPTSpan(input);

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

     public static IEnumerable<object[]> PartOneData =>
          new[]
          {
               ["(())", 0],
               ["()()", 0],
               ["(((", 3],
               ["(()(()(", 3],
               ["))(((((", 3],
               ["())", -1],
               ["))(", -1],
               [")))", -3],
               new object[] { ")())())", -3 }
          };
}