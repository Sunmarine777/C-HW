Console.WriteLine("Enter positive number ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("number = " + N + " -> ");

int i = 1;

if (i % 2 > 0)
i++;

while (i <= N)
{
      Console.Write(i + "     ");
      i = i + 2;
}
