Console.WriteLine("Введите координаты первой точки");
Console.Write(" x1 = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write(" y1 = ");
int y1 = int.Parse(Console.ReadLine());
Console.Write(" z1 = ");
int z1 = int.Parse(Console.ReadLine());


Console.Write(" x2 = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write(" y2 = ");
int y2 = int.Parse(Console.ReadLine());
Console.Write(" z2 = ");
int z2 = int.Parse(Console.ReadLine());



double distanse = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Растояние между точками равно: {distanse}");
