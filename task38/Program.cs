/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int a = 8;
int[] ArrayOutput() // Название метода Вывод случайных чисел
{
    Console.Write("[");
    int[] arra = new int[a];
    var random = new Random();

    for (int i = 0; i < a; i++)
    {
        arra[i] = random.Next(0, 99);
        Console.Write(arra[i]);
        if (i < a - 1)
            Console.Write(", ");
    }
    Console.Write("]");
    return arra;
}

void DifferenceMaxMin(int[] arr) // Название метода Разница между max & min
{
    int lengts = arr.Length;
    int max = arr[0];
    int min = arr[0];
    for (int j = 0; j < lengts; j++)
    {
        int temp = int.Parse(arr[j] + "");

        if (temp > max)
            max = temp;
        if (temp < min)
            min = temp;
    }
    Console.WriteLine(max - min);
}

Console.WriteLine("Программа вывода разницы между максимальным и минимальным элементов массива");

var array = ArrayOutput();
Console.WriteLine();
DifferenceMaxMin(array);

