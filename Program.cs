// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[8];
Console.WriteLine("____________________________________________________");
Console.WriteLine("Задача 34 :");
FillArray(array);
PrintArray(array);
Task34(array);

Console.WriteLine("Задача 36 :");
Task36(array);

void PrintArray(int[] currentArray)
{
    Console.WriteLine("Вывод массива на печать...");
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write(currentArray[i] + "\t");
    }
    Console.WriteLine();
}
void FillArray(int[] currentArray)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.Next(100, 1000);
    }
}

void Task34(int[] currentArray)
{
    int count = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i] % 2 == 0) count++;
    }
    Console.WriteLine($"Колличество четных чисел в массиве равно {count}");
    Console.WriteLine("____________________________________________________");
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

void Task36(int[] currentArray)
{
    {
    int sum = 0;
    for (int i = 0; i < currentArray.Length; i += 2)
    {
        sum += currentArray[i];
    }
    Console.WriteLine($"В массиве сумма чисел с нечетными индексами равна {sum}");
    Console.WriteLine("____________________________________________________");
}
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива. 

Console.WriteLine("____________________________________________________");
Console.WriteLine("Задача 38 :");
double[] Arraydouble = new double[5];

RandomArrayDouble(Arraydouble);
PrintArrayDouble(Arraydouble);
Task38(Arraydouble);

void RandomArrayDouble(double[] currentArray)
{
Random rand = new Random();
    for (int i = 0; i < Arraydouble.Length; i++)
    {
        Arraydouble[i] = rand.NextDouble() * 1000 - 500;
    }
}

void PrintArrayDouble(double[] currentArray)
{
    Console.WriteLine("Вывод массива на печать...");
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write(currentArray[i] + "\t");
    }
    Console.WriteLine();
}

void Task38(double[] currentArray)
{
    double min = currentArray[0];
    double max = currentArray[0];
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i] > max) max = currentArray[i];
        else if(currentArray[i] < min) min = currentArray[i];
    }
    Console.WriteLine($"Разность равна {max} - {min} = {max - min}");
}