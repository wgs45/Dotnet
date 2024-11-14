// boolean logic example 
Console.WriteLine("Boolean logic");

double timeToDinner = 4;
double distance = 95;
double rate = 30;

double tripDuration = distance / rate;
bool answer = tripDuration <= timeToDinner;
Console.WriteLine(answer);

Console.WriteLine("-------------------------------------");

// another boolean logic example
Console.WriteLine("Boolean logic");

bool beach = true;
bool hiking = false;
bool city = true;
bool yourNeeds = beach && city;
bool friendNeeds = beach || hiking;

bool tripDecision = yourNeeds && friendNeeds;
Console.WriteLine(tripDecision);

Console.WriteLine("-------------------------------------");

// If statement
Console.WriteLine("If statement");

int socks = 3;
if (socks <= 3)
{
    Console.WriteLine("Time to do laundry!");
}

Console.WriteLine("-------------------------------------");

// Conditional statements
Console.WriteLine("Conditional statement");

int people = 10;
string weather = "nice";

if (people <= 10 && weather == "nice")
{
    Console.WriteLine("SaladMart");
}
else
{
    Console.WriteLine("Soup N Sandwich");
}

Console.WriteLine("-------------------------------------");

// Else if statement
Console.WriteLine("Else if statement");

double ph_1 = 3.0;

if (ph_1 < 7)
{
    Console.WriteLine("Acidic");
}
else if (ph_1 > 7)
{
    Console.WriteLine("Basic");
}
else
{
    Console.WriteLine("Neutral");
}

Console.WriteLine("-------------------------------------");

// Switch statement
Console.WriteLine("Switch statement");

double ph_2 = 4.5;


switch (ph_2)
{
    case <= 3:
        Console.WriteLine("Very Acidic");
        break;
    case < 7:
        Console.WriteLine("Acidic");
        break;
    case >= 11:
        Console.WriteLine("Very Basic");
        break;
    case > 7:
        Console.WriteLine("Basic");
        break;
    default:
        Console.WriteLine("Neutral");
        break;
}

Console.WriteLine("-------------------------------------");

// Ternary operators
Console.WriteLine("Ternary operators");

int pepperLength = 4;
string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";
Console.WriteLine(message);
