// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// если k1==k2 прямые параллельные
// x= b2-b1/k1-k2

int InputNum(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

double CalcilationX(float perK1, int perB1, int perK2, int perB2)
{
    return (perB2 - perB1) / (perK1 - perK2);
}

double CalcilationY(int perK2, double perX, int perB2)
{
    return perK2 * perX + perB2;
}

int prmnK1 = InputNum("Введите значение k1: ");
int prmnB1 = InputNum("Введите значение b1: ");
int prmnK2 = InputNum("Введите значение k2: ");
int prmnB2 = InputNum("Введите значение b2: ");
if (prmnK1 == prmnK2) Console.Write("Прямые параллельны друг другу и не пересекаются.");
else
{
    double prmnX = CalcilationX(prmnK1, prmnB1, prmnK2, prmnB2);
    double prmnY = CalcilationY(prmnK2, prmnX, prmnB2);
    Console.Write($"Точка пересечения двух прямых находится в координатах ({prmnX + " " + prmnY}).");
}