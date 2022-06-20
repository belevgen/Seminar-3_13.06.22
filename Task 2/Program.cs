// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.

int prompt(string message)
{
    Console.WriteLine(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

double Sqr(double Num)
{
    return Num * Num;
}

int x1 = prompt("Введите x1");
int y1 = prompt("Введите y1");
int z1 = prompt("Введите z1");
int x2 = prompt("Введите x2");
int y2 = prompt("Введите y2");
int z2 = prompt("Введите z2");

double Dist(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double S = Sqr(x2 - x1) + Sqr(y1 - y1) + Sqr(z2 - z1);
    double result = Math.Sqrt(S);
    return result;
}

Console.WriteLine($"Расстояние между точками составляет {Dist(x1, y1, z1, x2, y2, z2)}");
