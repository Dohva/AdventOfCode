namespace TwoThousandAndFifteen.Lib.DayOne.Implementations;

public class DayTwoSolution : IDayTwoSolution
{
    public int GetWrappingPaperArea(string boxDimensions)
    {
        var boxSpecifications = SplitIntoBoxDimensions(boxDimensions);
        var sum = 0;

        foreach (var box in boxSpecifications)
        {
            sum += CalculateBoxArea(CreateBoxByDimensionString(box));
        }

        return sum;
    }

    public string[] SplitIntoBoxDimensions(string dimensions)
    {
        return dimensions.Split('\n');
    }

    public Box CreateBoxByDimensionString(string input)
    {
        var dimensions = input.Split('x');
        var dimensionIntegers = dimensions.Select(int.Parse).ToArray();
        return new Box(dimensionIntegers[0], dimensionIntegers[1], dimensionIntegers[2]);
    }

    public int CalculateBoxArea(Box box)
    {
        var widthAndLength = box.Width * box.Length;
        var heightAndWidth = box.Height * box.Width;
        var lengthAndHeight = box.Length * box.Height;

        var leastSide = 0;
        
        if (widthAndLength < heightAndWidth && widthAndLength < lengthAndHeight)
        {
           leastSide = widthAndLength;
        }
        else if (heightAndWidth < widthAndLength && heightAndWidth < lengthAndHeight)
        {
            leastSide = heightAndWidth;
        }
        else if (lengthAndHeight < heightAndWidth && lengthAndHeight < widthAndLength)
        {
            leastSide = lengthAndHeight;
        }

        return (widthAndLength + lengthAndHeight + heightAndWidth) * 2 + leastSide;
    }

    public class Box(int height, int length, int width)
    {
        public readonly int Width = width;
        public readonly int Height = height;
        public readonly int Length = length;
    }
}