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
