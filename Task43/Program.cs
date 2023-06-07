// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetNumberPosition()
{
    double num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void GetPointPosition(double b1, double k1, double b2, double k2)
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = Math.Round((k1 * x + b1), 2);
    Console.WriteLine($"Точка пересечения -> ({x}; {y})");
}

Console.WriteLine("Введите позиции двух точек: ");
Console.Write("B1: ");
double b1 = GetNumberPosition();

Console.Write("K1: ");
double k1 = GetNumberPosition();

Console.Write("B2: ");
double b2 = GetNumberPosition();

Console.Write("K2: ");
double k2 = GetNumberPosition();

GetPointPosition(b1, k1, b2, k2);