// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[]CreateArrayInt (int size)  // объект для создания массива
{
    int[]array = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i]=rnd.Next(-10, 10);
    }
    return array; 
}
int SumNegIndex(int[]arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (i % 2 != 0) sum += arr[i];
    }
    return sum;
}
void PrintArray (int[]array) // метод для вывода в консоль
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]} ]");
}

Console.WriteLine("Введите количество элементов в массиве.");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма элементов на нечетных позициях в массиве ");
int[]newArray = CreateArrayInt (number);
PrintArray(newArray);
int result = SumNegIndex(newArray);
Console.WriteLine($" = {result}.");