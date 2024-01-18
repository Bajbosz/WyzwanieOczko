using WyzwanieOczko;

Employee user0 = new Employee("Adam", "Moto", 13);
Employee user1 = new Employee("Antonio", "Moto", 15 );
Employee user2 = new Employee("Abraham", "Moto", 19 );

// nadawanie wartości pracownikom
for (int i=0; i<5; i++)
{
    Random random = new Random();
    int numberOfParticipants = 10;
    int winner = random.Next(1, numberOfParticipants + 1);
    user0.AddScore(winner);
}
for (int i = 0; i < 5; i++)
{
    Random random = new Random();
    int numberOfParticipants = 10;
    int winner = random.Next(1, numberOfParticipants + 1);
    user1.AddScore(winner);
}
for (int i = 0; i < 5; i++)
{
    Random random = new Random();
    int numberOfParticipants = 10;
    int winner = random.Next(1, numberOfParticipants + 1);
    user2.AddScore(winner);
}

// grupowanie ocen 
int result0 = user0.Result;
int result1 = user1.Result;
int result2 = user2.Result;
List<int> end = new List<int>();
end.Add(result0);
end.Add(result1);
end.Add(result2);
// wypisywanie wartości na konsoli
if ( end.Max() == result0)
{ 
    Console.WriteLine(user0.Name +" "+ user0.SurName + " " + user0.Age + " " + user0.Result);
    Console.WriteLine(end.Max());
}
 else if ( end.Max() == result1)
{ 
    Console.WriteLine(user1.Name + " " + user1.SurName + "  " + user1.Age + "  " + user1.Result);
    Console.WriteLine(end.Max());
}
else if ( end.Max() == result2)
{
    Console.WriteLine(user2.Name + "  " + user2.SurName + "  " + user2.Age + "  " + user2.Result);
    Console.WriteLine(end.Max());
}