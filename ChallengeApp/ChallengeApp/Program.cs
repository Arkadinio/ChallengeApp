// Lekcja 4


var name = "Ewa";
var gender = "kobieta";
var age = 29;


if (age < 30 && gender == "kobieta")
{
    Console.WriteLine(gender + " poniżej 30 lat");
}
else if (age == 33 && name == "Ewa")
{
    Console.WriteLine(name + ", lat 33");
}
else if (age < 18 && gender == "mężczyzna")
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Pozostałe");
}