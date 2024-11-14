namespace TwoThousandAndFifteen.Lib.DayOne.Implementations;

public class DayOneSolution : IDayOneSolution
{
    public int PartOne(string floors)
    {
        int result = 0;

        foreach (char floor in floors)
        {
            result += CharacterStepDirection(floor);
        }

        return result;
    }

    public int PartTwo(string floors)
    {
        int result = 0;

        for (int i = 0; i < floors.Length; i++)
        {
            result += CharacterStepDirection(floors[i]);

            if (result < 0) return i+1;
        }
        
        throw new ArgumentException("Character never entered basement.");
    }



    private int CharacterStepDirection(char input)
    {
        if (input == '(') return 1;
        if (input == ')') return -1;

        throw new ArgumentException("Character fell outside of category. Must be '(' or ')'.");
    }
}