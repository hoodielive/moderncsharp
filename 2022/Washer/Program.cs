// New non-destructive mutation for anonymous types.

var a1 = new {A=1, B=2, C=3, D=4, E=5};

var a2 = a1 with { E = 10 };

Console.WriteLine(a2);


// New deconstruction syntax.

var point = (3, 4);
double x = 0;
(x, double y) = point;

Console.WriteLine(point);


record struct Point(int X, int Y);
