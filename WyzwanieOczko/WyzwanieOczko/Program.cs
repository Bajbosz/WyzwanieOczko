using WyzwanieOczko;

Employee user0 = new Employee("Adam", "Moto", 13);
Employee user1 = new Employee("Antonio", "Moto", 15);
Employee user2 = new Employee("Abraham", "Moto", 19);

user0.AddScore("2000");
user0.AddScore("Tak");
user0.AddScore(6);
user0.AddScore(6);
var statistics =user0.GetStatistics();

Console.WriteLine($"dane: {statistics.Max}");


/*
List<Employee> PunktList = new List<Employee>()
{ 
    user0, user1, user2
};

foreach (var users in PunktList )
{
    for (int i = 0; i < 5; i++)
    {
        Random random = new Random();
        int numberOfParticipants = 10;
        int winner = random.Next(1, numberOfParticipants + 1);
        users.AddScore(winner);
    }
}

var MaxScoreEmployee = -1;

foreach (var item in PunktList)
{
    if (MaxScoreEmployee < item.Result) 
    {
        MaxScoreEmployee = item.Result;        
    }
}

foreach (var item in PunktList)
{
    if (MaxScoreEmployee == item.Result)
    {
        Console.WriteLine(item.Name + " " + item.SurName + " " + item.Age + " " + item.Result);
    }
}*/