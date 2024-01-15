using System.ComponentModel.Design;

var imie = "Adolf";
var wiek = 45;
char plec = 'M';


if (plec == 'K' && wiek > 30)
{
    Console.WriteLine("kobieta poniżej 30 lat");
}
else if (imie == "Ewa" && wiek == 30) 
{
    Console.WriteLine("Ewa lat 30");
}
else if (plec  ==   'M' && wiek<18) 
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
