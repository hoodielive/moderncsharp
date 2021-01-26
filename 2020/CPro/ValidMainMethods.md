# Valid Main Methods

```csharp
public static void Main() {}
public static int Main() {}
public static void Main(string[] args) {}
public static async Task Main() {}
public static async Task<int> Main() {}
public static async Task Main(string[] args) {}
public static async Task<int> Main(string[] args) {}
```

## Basic Builtin Types:
- bool = System.Boolean
- float = System.Single
- int = System.Int32
- string = System.String
- char = System.Char

```csharp
Type sType = typeof(String);
Console.WriteLine(sType.FullName);
```

## Math Functions
Abs - absolute value - Math.Abs() or Mathf.Abs()
Round - rounding - Math.Round()
Floor - round down irrespective of the decimal value - Math.Floor()
Ceil - round up to nearest int irrespective of the decimal value - Math.Ceil()
Truncate - round to int irrespective of the decimal value - Math.Truncate(5.9) # 5
Min - pick the lowest value - Math.Min(1, 3);
Max - pick the highest value - Math.Max(1, 3);

## String
Under the hood a string is seen as an array of readonly characters. For example:
```
string s1 = "abc";
readonly System.Char[] s = new System.Char[] { 'a', 'b', 'c' };
```
...are identical.

- Strings are immutable (readonly).
- Check with string equality with (==) or the preferred way is string.Equals(s1, s2);
- @ is the verbatim identifier - since if is a keyword, it can't be used as a keyword, however
	you can use the verbatim identifier to use it @if.
- $ specifies that the string should be interpreted $"{str}"
