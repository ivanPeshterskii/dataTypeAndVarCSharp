﻿int n = int.Parse(Console.ReadLine());

string biggestKeg = null;
double biggestVolume = default;


for(int i = 0; i < n; i++)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    double volume = Math.PI * Math.Pow(radius, 2) * height;

    if (volume > biggestVolume)
    {
        biggestVolume = volume;
        biggestKeg = model; 
    }


}
Console.WriteLine(biggestKeg);