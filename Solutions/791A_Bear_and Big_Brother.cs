int sum = 0;
var n = Console.ReadLine().Split();
int limak = int.Parse(n[0]);
int bob = int.Parse(n[1]);

while(bob >= limak)
{
    bob = bob * 2;
    limak = limak * 3;
    sum += 1;
}

Console.WriteLine(sum);
