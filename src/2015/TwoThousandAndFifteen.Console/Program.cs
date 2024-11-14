using System.Text;
using TwoThousandAndFifteen.Console.Apps;

string[] completedDays =
[
    "1"
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
        var dayOneApp = new DayOneResult();
        Console.WriteLine(dayOneApp.Result());
        break;
    }
    default:
        Console.WriteLine("Wrong answer!");
        break;
}

Console.WriteLine("Thanks for playing!");