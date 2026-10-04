int sum = 0;
var n = int.Parse(Console.ReadLine());

while (n-- > 0)
{
    var num = Console.ReadLine().Split();
    if (int.Parse(num[0]) + int.Parse(num[1]) + int.Parse(num[2]) >= 2)
    {
        sum += 1;
    }
}

Console.WriteLine(sum);
