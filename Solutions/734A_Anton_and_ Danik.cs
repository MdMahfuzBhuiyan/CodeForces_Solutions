int a = 0, d = 0;
var n = int.Parse(Console.ReadLine());
var s = Console.ReadLine();

foreach(char c in s)
{
    if (c == 'A') a++;
    else d++;
}

if (a > d) Console.WriteLine("Anton");
else if (a < d) Console.WriteLine("Danik");
else Console.WriteLine("Friendship");
