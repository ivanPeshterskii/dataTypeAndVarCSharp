int number = int.Parse(Console.ReadLine());

int sum = default;

while (true)
{
    int digit = number % 10;
    number /= 10;

    sum += digit;

    if (number == 0)
    {
        break; 
    }
}
Console.WriteLine(sum);