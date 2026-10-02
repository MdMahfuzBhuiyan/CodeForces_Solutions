int sum = 0;
var input = Console.ReadLine().Split();
var h = int.Parse(input[1]);

var hP = Console.ReadLine().Split();

foreach (var i in hP)
{
    if (h >= int.Parse(i)) sum += 1;
    else sum += 2;
}

Console.WriteLine(sum);
