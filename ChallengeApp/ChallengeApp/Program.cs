﻿// Lekcja 4


var Name = "Ewa";
var Gender = "kobieta";
var Age = 29;


if (Age<30 && Gender=="kobieta" )
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (Age == 33)
{
    Console.WriteLine(Name + ", lat 33");
}
else if (Age <18 &&  Gender=="mężczyzna")
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Pozostałe");
}