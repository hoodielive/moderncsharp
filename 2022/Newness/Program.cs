using System;


int x = 12 * 30;
System.Console.WriteLine(x);

SayHello();

Console.WriteLine(FeetToInches(30));


int FeetToInches(int feet)
{
   int inches = feet * 12;
   return inches;
}

void SayHello()
{
    Console.WriteLine("Hello, world!");
}

string message = "Hello, World";
string upperMessage = message.ToUpper();
Console.WriteLine(upperMessage);

int x = 2022;
message = message + x.ToString();

var node = new JsonArray
{
    new JsonObject {
        ["Name"] = "Osa",
        ["Age"] =  40,
        ["Friends"] = new JsonArray("Oyeku", "Ogbe");
    },

    new JsonObject {
        ["Name"] = "Otura",
        ["Age"] = 50,
        ["Friends"] = new JsonArray("Otura", "Irete");
    }
};

Console.WriteLine(node);
