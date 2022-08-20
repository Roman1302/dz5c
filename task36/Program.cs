/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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

var array = ArrayOutput();

Console.WriteLine();

int result = 0;
int lengts = array.Length;

for (int j = 1; j < lengts; j += 2)
{
    int temp = int.Parse(array[j] + "");
    result = temp + result;
}
Console.WriteLine(result);