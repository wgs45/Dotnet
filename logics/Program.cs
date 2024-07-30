// boolean logic example 

double timeToDinner = 4;
double distance = 95;
double rate = 30;

double tripDuration = distance / rate;
bool answer = tripDuration <= timeToDinner;
Console.WriteLine(answer);

Console.WriteLine("-------------------------------------");

// another boolean logic example

bool beach = true;
bool hiking = false;
bool city = true;
bool yourNeeds = beach && city;
bool friendNeeds = beach || hiking;

bool tripDecision = yourNeeds && friendNeeds;
Console.WriteLine(tripDecision);

Console.WriteLine("-------------------------------------");

// conditional statement example 
