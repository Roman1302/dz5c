/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int a = 8; //Длина массива
int[] ArrayOutput() // название метода Вывод случайных числе 
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

void SumOddPositions(int[] arr) //название метода Сумма нечетных позиций
{
    int result = 0;
    int lengts = arr.Length;

    for (int j = 1; j < lengts; j += 2)
    {
        int temp = int.Parse(arr[j] + "");
        result = temp + result;
    }
Console.WriteLine(result);
}

Console.WriteLine("Программа вывода суммы элементов, стоящих на нечётных позициях массива");
var array = ArrayOutput();
Console.WriteLine();
SumOddPositions(array);