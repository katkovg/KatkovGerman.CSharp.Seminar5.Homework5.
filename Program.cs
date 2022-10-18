// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] createArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(100, 1000);
    }
    return array;
}

void showEvenNumbers (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 == 0) { Console.WriteLine(array [i] + " "); };
    }
}

void showArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array [i] + " ");
    }
}

Console.WriteLine("Input a size of array:");
int size = Convert.ToInt32(Console.ReadLine());
if (size <= 0) 
{ 
    while (size <= 0)
    {
        Console.WriteLine("Input a size greater than zero:");
        size = Convert.ToInt32(Console.ReadLine());
    }
}

int [] array = new int [size];

Console.WriteLine();

array = createArray(array);

if (size > 1)
{
    Console.WriteLine("These are all the numbers of array:");
    showArray(array);
    Console.WriteLine();
    Console.WriteLine("These are only even numbers of array:");
    showEvenNumbers(array);
}

if (size == 1)
{
    if (array [0] % 2 == 0)
    {
        Console.WriteLine($"Your array has only one number: {array [0]}. It is an even number.");
    }
    else if (array [0] % 2 != 0)
    {
        Console.WriteLine($"Your array has only one number: {array [0]}. It is an odd number.");
    }
    else
    {
        Console.WriteLine("These are only even numbers of array:");
        showEvenNumbers(array);
    }
}
*/

// Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] createArray (int [] array, int minimal, int maximal)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(minimal, maximal + 1);
    }
    return array;
}

void showArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array [i] + " ");
    }
}

void showOddNumbers (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 != 0) { Console.WriteLine(array [i] + " "); };
    }
}

int oddNumbersSum (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 != 0) { sum += array [i]; };
    }
    return sum;
}

Console.WriteLine("Input a size of array:");
int size = Convert.ToInt32(Console.ReadLine());

if (size == 1 || size <= 0) 
{
    while (size == 1 || size <= 0)
    {
    Console.WriteLine("It is necessary to input a size greater than one to determine sum of minimal and maximal values.");
    size = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Input a minimal number:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a maximal number:");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [] array = new int [size];
array = createArray (array, minValue, maxValue);

Console.WriteLine("These are all the numbers of array:");
showArray (array);
Console.WriteLine();

Console.WriteLine("These are only odd numbers of array:");
showOddNumbers(array);
Console.WriteLine();

Console.WriteLine($"The sum of odd numbers is: {oddNumbersSum(array)}");
*/

// Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double [] createArray (double [] array, double minimal, double maximal)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().NextDouble() * (maximal - minimal) + minimal;
    }
    return array;
}

void showArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array [i] + " ");
    }
}

void differenceBeetwenMaxAndMin (double [] array)
{
    double maximalElement = array [0];
    double minimalElement = array [0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > maximalElement)
        {
            maximalElement = array [i];
        }
        else if (array [i] < minimalElement)
        {
            minimalElement = array [i];
        }
    }
    double difference = maximalElement - minimalElement;
    Console.WriteLine($"The minimal number is: {minimalElement}.");
    Console.WriteLine($"The maximal number is: {maximalElement}.");
    Console.WriteLine($"The difference is: {difference}.");
}
Console.WriteLine("Input a size of array:");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a minimal real number:");
double minValue = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input a maximal real number:");
double maxValue = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

double [] array = new double [size];

array = createArray (array, minValue, maxValue);

Console.WriteLine("These are all the numbers of array:");
showArray(array);
Console.WriteLine();

differenceBeetwenMaxAndMin(array);
*/