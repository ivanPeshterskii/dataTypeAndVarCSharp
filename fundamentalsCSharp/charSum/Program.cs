int n = int.Parse(Console.ReadLine());
int sum = default;

for (int i = 0; i < n; i++)
{
    char c = char.Parse(Console.ReadLine());
    sum += (int)c; 
}

Console.WriteLine($"The sum equals: {sum}");