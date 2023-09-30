using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("=============================================");
Console.WriteLine();

var Supervisor = new Supervisor("Jan","AS");

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        Supervisor.AddGrade(input);
    }
    catch (Exception e)
    {

        Console.WriteLine($"Exception catched:  {e.Message}");
    }

}

var statistics = Supervisor.GetStatistics();
Console.WriteLine($"AVG: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"MAX: {statistics.Max}");
Console.WriteLine($"AVGLetter: {statistics.AverageLetter}");