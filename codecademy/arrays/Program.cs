Console.WriteLine("Arrays");

string[] summerStrut;
summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

int[] ratings = { 1, 1, 1, 1, 1, 1, 1, 1 };

Console.WriteLine("-------------------------------------");

Console.WriteLine("Array Len");

if (summerStrut.Length == 8)
{
    Console.WriteLine("summerStrut Playlist is ready to go!");
}
else if (summerStrut.Length > 8)
{
    Console.WriteLine("Too many songs!");
}
else if (summerStrut.Length < 8)
{
    Console.WriteLine("Add some songs!");
}

Console.WriteLine("-------------------------------------");

Console.WriteLine("Accessing Arrays");

Console.WriteLine($"You rated the song {summerStrut[1]} {ratings[1]} stars.");


Console.WriteLine("-------------------------------------");

Console.WriteLine("Editing Arrays");

summerStrut[7] = "Yukidoke";
ratings[7] = 5;

Console.WriteLine("-------------------------------------");

Console.WriteLine("Build-in Methods in Arrays");

int threeRating = Array.IndexOf(ratings, 3);
Console.WriteLine($"Song number {threeRating + 1} is rated three stars.");

Array.Reverse(summerStrut);
string newFirst = summerStrut[0];
string newLast = summerStrut[7];
Console.WriteLine($"The first song in the playlist is now {newFirst}.");
Console.WriteLine($"The last song in the playlist is now {newLast}.");

Array.Sort(summerStrut);
string firstSong = summerStrut[0];
string lastSong = summerStrut[7];
Console.WriteLine($"The first song in the playlist is now {firstSong}.");
Console.WriteLine($"The last song in the playlist is now {lastSong}.");


Console.WriteLine("-------------------------------------");
