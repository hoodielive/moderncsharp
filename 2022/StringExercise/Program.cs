string firstFriend = "Vincent";
string secondFriend = "Jordan";
Console.WriteLine($"Hello {firstFriend} and {secondFriend} ");
Console.WriteLine($"The length of {firstFriend} is {firstFriend.Length}");

string greeting = "                                 Howdy!";
string greetingE = "Howdy!                                ";
string greetingM = "            Howdy!                    ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

Console.WriteLine($"[{greetingE}]");
string trimmedGreetingE = greetingE.TrimEnd();
Console.WriteLine($"[{trimmedGreetingE}]");

Console.WriteLine($"[{greetingM}]");
string trimmedGreetingM = greetingM.Trim();
Console.WriteLine($"[{greetingM}]");

string sayHowdy = "Hello World!";
Console.WriteLine(sayHowdy);
sayHowdy = sayHowdy.Replace("Hello", "Greetings");
Console.WriteLine(sayHowdy);

Console.WriteLine(sayHowdy.Contains("World!"));
Console.WriteLine(sayHowdy.StartsWith("Greetings"));
Console.WriteLine(sayHowdy.EndsWith("World"));
Console.WriteLine(sayHowdy.EndsWith("Worlds"));
Console.WriteLine(sayHowdy.EndsWith("World!"));
int a = 5;
int b = 4;
int c = 2;
int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine(d);

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range rof integers id {min} to {max}");
