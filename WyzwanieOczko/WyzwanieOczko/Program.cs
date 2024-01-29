using WyzwanieOczko;
Console.WriteLine(" || Witamy w programie do oceny pracownika || ");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("");
Employee user0 = new Employee("Bartosz", "Moto", 44);
while(true)
{
    Console.WriteLine("Podaj oceneę pracownika:");
    var input = Console.ReadLine();
    if(input == "q")
    { 
        break; 
    }
    user0.AddScore(input);
}

var statistics = user0.GetStatistics();

Console.WriteLine($"Avg: {statistics.Avg}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Letter: {statistics.AvgLetter}");