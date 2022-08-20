// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных 
// чисел в массиве.
// [345, 897, 568, 234] -> 2

int[]CreateArrayInt (int size)  // объект для создания массива
{
    int[]array = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i]=rnd.Next(99, 1000);
    }
    return array; 
}
int QuantityElem(int[]arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
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
Console.Write($"Количество четных чисел в массиве ");
int[]newArray = CreateArrayInt (number);
PrintArray(newArray);
int result = QuantityElem(newArray);
Console.WriteLine($" = {result}.");