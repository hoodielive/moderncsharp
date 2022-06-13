
int x = new System.Random().Next(4);

string result = x switch {
  0 => "zero",
  1 => "one",
  _ => "more than one"
};

System.Console.WriteLine($"x is {result}.");

UnitConverter feetToInches = new UnitConverter(12);
UnitConverter milesToFeet = new UnitConverter(5280);

Console.WriteLine(feetToInches.Convert(30));
Console.WriteLine(feetToInches.Convert(100));
Console.WriteLine(feetToInches.Convert(milesToFeet.Convert(1)));
