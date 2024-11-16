using FluentAssertions;
using TwoThousandAndFifteen.Lib.DayOne;
using TwoThousandAndFifteen.Lib.DayOne.Implementations;

namespace TwoThousandAndFifteen.Tests.Unit.Tests.DayTwo;

public class DayTwoSolutionTests
{
    private readonly IDayTwoSolution _sut = new DayTwoSolution();
    
    [Theory]
    [MemberData(nameof(BoxAreaData))]
    public void CalculateBoxAreaShould_GetCorrectAreaOfBox_GivenTheBoxDimensions(string input, int expected)
    {
        var result = _sut.GetWrappingPaperArea(input);

        result.Should().Be(expected);
    }

   public static IEnumerable<Object[]> BoxAreaData => new[]
    {
        (object[]) ["2x3x4", 58],
        ["1x1x10", 43],
        ["2x3x4\n1x1x10", 101]
    };
}