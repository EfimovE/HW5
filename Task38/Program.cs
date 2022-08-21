// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[]CreateArrayDouble (int size, int min, int max)  // объект для создания массива
{
    double[]array = new double [size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i]=Math.Round(rnd.NextDouble() * (max-min) + min, 1);
    }
    return array; 
}
double DifferenceNumMaxMin(double[]arr)
{
    double numMax = arr[0];
    double numMin = arr[0];
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > numMax) numMax = arr[i];
        if (arr[i] < numMin) numMin = arr[i];
    }
    // Console.WriteLine(numMax);
    // Console.WriteLine(numMin);
    double differenceNum = numMax - numMin;
    // Console.WriteLine(differenceNum);
    return differenceNum;
}
void PrintArray (double[]array) // метод для вывода в консоль
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]} ]");
}

Console.WriteLine("Введите количество элементов в массиве и нажмите Enter.");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента в массиве и нажмите Enter.");
int minEl = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента в массиве и нажмите Enter.");
int maxEl = Convert.ToInt32(Console.ReadLine());
Console.Write($"Разница между максимальным и минимальным значениями элементов в массиве ");
double[]newArray = CreateArrayDouble (number, minEl, maxEl);
PrintArray(newArray);
double result = DifferenceNumMaxMin(newArray);
Console.WriteLine($" = {result}.");

