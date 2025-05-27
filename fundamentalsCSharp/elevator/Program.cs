int numberPeaple = int.Parse(Console.ReadLine());
int capacility = int.Parse(Console.ReadLine());

int coures = (int)Math.Ceiling((double)numberPeaple / capacility);
Console.WriteLine(coures);