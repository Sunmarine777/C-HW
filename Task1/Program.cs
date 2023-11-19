// Example1
int a = 5;
int b = 7;

int max = a;
int min = a;

if (a > max) max = a;
if (b > max) max = b;
if (a < min) min = a;
if (b < min) min = b;

Console.Write(max);
Console.Write(" is bigger and ");
Console.Write(min);
Console.Write(" is smaller");

/*Example2
int a = 2;
int b = 10;

int max = a;
int min = a;

if (a > max) max = a;
if (b > max) max = b;
if (a < min) min = a;
if (b < min) min = b;

Console.Write("max = ");
Console.WriteLine(max);
Console.WriteLine("and");
Console.Write("min = ");
Console.Write(min);

Example3
int a = -9;
int b = -3;

int max = a;
int min = a;

if (a > max) max = a;
if (b > max) max = b;
if (a < min) min = a;
if (b < min) min = b;

Console.Write("max = ");
Console.WriteLine(max);
Console.WriteLine("and");
Console.Write("min = ");
Console.Write(min); */