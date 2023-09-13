using ChallengeApp;

var employee = new Employee("Adam", "Kamizelich");

//employee.AddGrade("Adam");
//employee.AddGrade("4000");
employee.AddGrade(2);
employee.AddGrade(6);
employee.AddGrade(2);
employee.AddGrade(3);

var statistics = employee.GetStatistics();

var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine("-----------------------ForEach----------------------------");

Console.WriteLine($"Average: {statistics1.Average:N2}");

Console.WriteLine($"Min: {statistics1.Min}");

Console.WriteLine($"Max: {statistics1.Max}");

Console.WriteLine("-----------------------For--------------------------------");

Console.WriteLine($"Average: {statistics2.Average:N2}");

Console.WriteLine($"Min: {statistics2.Min}");

Console.WriteLine($"Max: {statistics2.Max}");

Console.WriteLine("-----------------------DoWhile----------------------------");

Console.WriteLine($"Average: {statistics3.Average:N2}");

Console.WriteLine($"Min: {statistics3.Min}");

Console.WriteLine($"Max: {statistics3.Max}");

Console.WriteLine("-----------------------While----------------------------");

Console.WriteLine($"Average: {statistics4.Average:N2}");

Console.WriteLine($"Min: {statistics4.Min}");

Console.WriteLine($"Max: {statistics4.Max}");
