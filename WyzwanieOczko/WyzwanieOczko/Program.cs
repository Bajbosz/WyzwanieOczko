
int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
var zero = 0;
var one = 0;
var two = 0;
var three = 0;
var four = 0;
var five = 0;
var six = 0;
var seven = 0;
var eight = 0;
var nine = 0;
foreach (char c in letters)
{
    if (c == '0')
    {
        zero++;
    }
    else if (c == '1')
    {
        one++;
    }
    else if (c == '2')
    {
        two++;
    }
    else if (c == '3')
    {
        three++;
    }
    else if (c == '4')
    {
        four++;
    }
    else if (c == '5')
    {
        five++;
    }
    else if (c == '6')
    {
        six++;
    }
    else if (c == '7')
    {
        seven++;
    }
    else if (c == '8')
    {
        eight++;
    }
    else if (c == '9')
    {
        nine++;
    }
}
Console.WriteLine("0=>" + zero);
Console.WriteLine("1=>" + one);
Console.WriteLine("2=>" + two);
Console.WriteLine("3=>" + three);
Console.WriteLine("4=>" + four);
Console.WriteLine("5=>" + five);
Console.WriteLine("6=>" + six);
Console.WriteLine("7=>" + seven);
Console.WriteLine("8=>" + eight);
Console.WriteLine("9=>" + nine);

