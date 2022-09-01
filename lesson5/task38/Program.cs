// Задача 36: Задайте одномерный массив,
// заполненный случайными числами. 
// Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int Find(int[] array)
{
    int result = 0;
    int min = 0;
    int max = 0;

        for (int i = 0; i < array.Length; i++)
            {
                if (array[min] > array[i])
                    min = i;
                else if (array[max] < array[i])
                    max = i;
            }

Console.WriteLine("min= " + array[min] + "\tmax= " + array[max]);
    if (array[min] > array[max])
        result = array[min] - array[max];
    else if (array[max] > array[min])
        result = array[max] - array[min];
    return result;
}
            
Console.Write("введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Console.Write("введите минимальное значение: ");
int Min = Convert.ToInt32(Console.ReadLine());
Console.Write("введите максимальное значение: ");
int Max = Convert.ToInt32(Console.ReadLine());
int temp = 0;
if (Min > Max)
    {
        temp = Max;
        Max = Min;
        Min = temp;
    }
Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(Min, Max);
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "\t");

Console.WriteLine("разница между минимальным и максимальным элементом массива=" + Find(array));