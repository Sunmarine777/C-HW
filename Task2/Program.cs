//Example1
Console.WriteLine("Enter 3 numbers : ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write(a + ", "+ b + ", "+ c + " -> " + max);

/*Example2
int a = 44;
int b = 5;
int c = 78;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine(max);*/

/*Example3
int a = 22, b = 3, c = 9;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine(max);*/