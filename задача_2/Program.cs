// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Расстояние = $ \ sqrt{(x2-x1) ^{2} + (y2-y1) ^{2} + (z2-z1) ^{2}}$ 

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}
int x1 = EnterData("Введите число x1: ");
int y1 = EnterData("Введите число y1: ");
int z1 = EnterData("Введите число z1: ");
int x2 = EnterData("Введите число x2: ");
int y2 = EnterData("Введите число y2: ");
int z2 = EnterData("Введите число z2: ");
double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}); -> {distance}");
