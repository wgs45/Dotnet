Console.WriteLine("Hello world");

// Console.WriteLine("How old are you?");
// string input = Console.ReadLine();
// Console.WriteLine($"You are {input} years old!");

int my_age = 32;
string country_name = "Indonesia";
Console.WriteLine(my_age);
Console.WriteLine(country_name);

Console.WriteLine("-------------------------------------");

int even_num = 22, odd_num = 45;
Console.WriteLine(even_num + odd_num);

Console.WriteLine("-------------------------------------");

// initialize variables
string name = "Shadow";
string breed = "Golden Retriever";
int age = 5;
double weight = 65.22;
bool spayed = true;

Console.WriteLine(name);
Console.WriteLine(breed);
Console.WriteLine(age);
Console.WriteLine(weight);
Console.WriteLine(spayed);

Console.WriteLine("-------------------------------------");

// Console.Write("Enter your favourite number: ");
// int faveNumber = Console.ReadLine();
// int faveNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Your favourite number is ", faveNumber);

Console.WriteLine("-------------------------------------");

// double is faster and more precise than int and float
// m is used to determine decimal variable type

int pizza_shops = 4332;
int total_employees = 86928;
double revenue = 390819.28;

Console.WriteLine(pizza_shops);
Console.WriteLine(total_employees);
Console.WriteLine(revenue);

Console.WriteLine("-------------------------------------");

int user_age = 20;
double jupiter_years = 11.86;
double jupiter_age = user_age / jupiter_years;
double journey_to_jupiter = 6.142466;

double new_earth_age = user_age + journey_to_jupiter;
double new_jupiter_age = new_earth_age / jupiter_years;

Console.WriteLine(new_earth_age);
Console.WriteLine(new_jupiter_age);

Console.WriteLine("-------------------------------------");

// increment and decrement methods

int steps = 0;
steps += 2;
steps -= 1;

Console.WriteLine(steps);

Console.WriteLine("-------------------------------------");

// arithmetics
// NaN => Not a Number

int students = 18;
int group_size = 5;
Console.WriteLine(students % group_size);

int number_1 = 12932;
int number_2 = Math.Abs(-2828472);

double number_1_sqrt = Math.Floor(Math.Sqrt(number_1));
Console.WriteLine(number_1_sqrt);

double number_2_sqrt = Math.Floor(Math.Sqrt(number_2));
Console.WriteLine(number_2_sqrt);

Math.Abs(number_2);
Console.WriteLine(Math.Min(number_1_sqrt, number_2_sqrt));

double numberOne = 6.5;
double numberTwo = 4;

Console.WriteLine(Math.Pow(numberOne, numberTwo));
Console.WriteLine(Math.Ceiling(numberOne));
Console.WriteLine(Math.Max(numberOne, numberTwo));

Console.WriteLine("-------------------------------------");

string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.";

string firstSpeech = "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"";

Console.WriteLine(firstSentence);
Console.WriteLine("\n");
Console.WriteLine(firstSpeech);

Console.WriteLine("-------------------------------------");

string beginning_1 = "hello";
string middle_1 = "world";
string end_1 = "alpha";

string story_1 = beginning_1 + middle_1 + end_1;
Console.WriteLine(story_1);

Console.WriteLine("-------------------------------------");

string beginning_2 = "Once upon a time,";
string middle_2 = "The kid climbed a tree";
string end_2 = "Everyone lived happily ever after.";

string story_2 = $"{beginning_2} it was a beautiful day. {middle_2} and the birds flew through the sky. {end_2}";
Console.WriteLine(story_2);

Console.WriteLine("-------------------------------------");

// get string info

string password = "a92301j2add";
int passwordLength = password.Length;
int passwordCheck = password.IndexOf("!");

// print results
Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");

Console.WriteLine("-------------------------------------");

// get parts of string

string startStrand = "ATGCGATGAGCTTAC";
int tga = startStrand.IndexOf("TGA");

int startPoint = 0;
int length = 3;
