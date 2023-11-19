//Example1
Console.Write("FirstNumber: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("SecondNumber: ");
int b = Convert.ToInt32(Console.ReadLine());

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
Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());

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
Console.Write(min);*/

/*Example3
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