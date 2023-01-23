// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Input(string msg)
{
    Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int[] ContainArr(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CountPositive(int[] arr)
{
    int countPositive = 0;
    for (int i = 0; i < arr.Length; i++) if (arr[i] > 0) countPositive++;
    return countPositive;
}

int length = Input("Введите количество чисел, которые вы хотите передать: ");
int[] mass = ContainArr(length);
Console.WriteLine($"Вы ввели следующие числа: {String.Join(", ", mass)}.");
Console.WriteLine($"Количество положительных чисел из них = {CountPositive(mass)}.");