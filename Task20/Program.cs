// Напишите программу, которая принимает на вход координаты двух точеки 
// и находит расстояние между ними в 2D пространстве
// А (3, 6); В (2, 1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double DistanceFromCoordinates(int ax, int ay, int bx, int by)
{
    double sumKatets = (bx - ax) * (bx - ax) + (by - ay) * (by - ay);
    double d = Math.Sqrt(sumKatets);
    return d;
}

Console.WriteLine("x1 = ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("y1 = ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("x2 = ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("y2 = ");
int y2 = int.Parse(Console.ReadLine());

double result = DistanceFromCoordinates(x1, y1, x2, y2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(resultRound);