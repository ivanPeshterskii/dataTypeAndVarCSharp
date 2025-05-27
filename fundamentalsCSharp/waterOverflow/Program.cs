int n = int.Parse(Console.ReadLine());

int currentLiters = 0; 
int capacility = 255;

for (int i = 0; i < n; i++)
{
    int litersFollow = int.Parse(Console.ReadLine());

    if (currentLiters + litersFollow > capacility)
        Console.WriteLine("Insufficient capacity!");
    else
        currentLiters += litersFollow;
}
Console.WriteLine(currentLiters);