/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int a = 8;
int[] ArrayOutput()
{
    Console.Write("[");
    int[] array = new int[a];
    var random = new Random();

    for (int i = 0; i < a; i++)
    {
        array[i] = random.Next(0, 99);
        Console.Write(array[i]);
        if (i < a - 1)
            Console.Write(", ");
    }
    Console.Write("]");
    return array;
}

Console.WriteLine("Программа вывода разницы между максимальным и минимальным элементов массива");

var array = ArrayOutput();

Console.WriteLine();


int lengts = array.Length;
int max = array[0];
int min = array[0];
for (int j = 0; j < lengts; j++)
{
    int temp = int.Parse(array[j] + "");

    if (temp > max)
        max = temp;
    if (temp < min)
        min = temp;
}

Console.WriteLine(max - min);