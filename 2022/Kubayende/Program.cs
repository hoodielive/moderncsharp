// See https://aka.ms/new-console-template for more information

class UnitConverter
{
    UnitConverter(int 100);
}
Console.WriteLine(FeetToInches (30));
Console.WriteLine(FeetToInches (100));

int x = 12 * 30;

FeetToInches(23);

Console.WriteLine(x);

int FeetToInches (int feet)
{
    int inches = feet * 12;
    return inches;
}

bool simpleVar = false;

if (simpleVar)
    Console.WriteLine("This will not print");

int xa = 5000;

bool lessThanAMile = x < 5280;

if (lessThanAMile)
    Console.WriteLine("This will however print.");

Console.WriteLine(xa);


// Heap Allocation in C#
UnitConverter feetToInchesConverter  = new UnitConverter(12);
UnitConverter milesToConverter  = new UnitConverter(5280);

Console.WriteLine(feetToInchesConverter(30));
Console.WriteLine(milesToConverter(100));
