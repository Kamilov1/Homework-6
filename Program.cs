void Zadacha41()
{
    //Задача 41: Пользователь вводит с клавиатуры M чисел. 
    //Посчитайте, сколько чисел больше 0 ввёл пользователь.

    Console.WriteLine("Введите количество чисел: ");
    int M = Convert.ToInt32(Console.ReadLine());

    int count = 0;
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Введено: {count} число, больше нули");
}

void Zadacha43()
{
    //Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
    //y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

    Console.WriteLine("Введите число: ");
    Console.Write("b1 = ");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("k1 = ");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("b2 = ");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("k2 = ");
    int k2 = Convert.ToInt32(Console.ReadLine());

    int x = 0;
    int y = k1 * x + b1; y = k2 * x + b2;

    while (k1 < k2 && k1 > k2)
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1; y = k2 * x + b2;
    }
    Console.WriteLine($"{x}, {y}");
}

//Zadacha41();
Zadacha43();