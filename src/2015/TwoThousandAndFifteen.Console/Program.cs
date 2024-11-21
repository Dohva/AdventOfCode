using System.Text;
using TwoThousandAndFifteen.Console.Apps;

string[] completedDays =
[
    "1",
    "2"
];

var sb = new StringBuilder();
sb.AppendLine("Enter your desired result below");

foreach (var day in completedDays)
{
    sb.AppendLine($"'{day}' for day {day}"); 
}

Console.WriteLine(sb);

switch (Console.ReadLine())
{
    case "1":
    {
        Console.WriteLine(new DayOneResult().Result());
        break;
    }
    case "2":
    {
        Console.WriteLine(new DayTwoResult().Result());
        break;
    }
    default:
        Console.WriteLine("Wrong answer!");
        break;
}

Console.WriteLine("Thanks for playing!");