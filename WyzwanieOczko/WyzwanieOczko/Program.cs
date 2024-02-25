using WyzwanieOczko;
Console.WriteLine(" || Witamy w programie do oceny pracownika || ");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("");
EmployeeInFile user0 = new EmployeeInFile("Bartosz", "Moto"); //, 44, 'M'
user0.GradeAdded += EmployeeGradeAdded;

    void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocene");
}

/*
user0.AddScore("50");
user0.AddScore(0.5f);
user0.AddScore(99);
*/

while (true)
{
        Console.WriteLine("Podaj ocenę pracownika:");
        var input = Console.ReadLine();
        if (input == "q")
        {
            break;
        }
    try
    {
        user0.AddScore(input);
    } 
    catch(Exception ex)
    { 
        Console.WriteLine(ex.Message);
    }    
}
var statistics = user0.GetStatistics();
Console.WriteLine($"Avg: {statistics.Avg}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Letter: {statistics.AvgLetter}");