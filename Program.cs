
/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2


int[] CreatRandomArray (int size, int minValue, int maxValue)
{
   
    int[] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue +1);         
          
    }
    
    return newArray;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
    
}
int Current (int[] array)
{
    int current = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0) current++;

    return current;

}

Console.Write("Input the array size from 1 to 100: ");
int usersize = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the three digit maxValue: ");
int userMax = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the three digit minValue: ");
int userMin = Convert.ToInt32(Console.ReadLine());

if (userMax <= 999 && userMin >= 100 && usersize <= 100) 
    {
    int[] userArray = CreatRandomArray (usersize, userMin, userMax);
    ShowArray(userArray);
    int chetNumber = Current(userArray);
    Console.Write($"The number of chetdigits is {chetNumber}");

    Console.WriteLine();

    }
else Console.Write("Try again! Something goes wrong!");
Console.WriteLine();
*/


/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0


int[] CreatRandomArray (int size, int minValue, int maxValue)
{
   
    int[] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue +1);         
          
    }
    
    return newArray;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
    
}
int Sum (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i +2)
    sum = sum + array[i];

    return sum;

}

Console.Write("Input the array size: ");
int usersize = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the maxValue: ");
int userMax = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the minValue: ");
int userMin = Convert.ToInt32(Console.ReadLine());

int[] userArray = CreatRandomArray (usersize, userMin, userMax);
ShowArray(userArray);
int totalSum = Sum(userArray);
Console.Write($"The sum is {totalSum}");

Console.WriteLine();
    
*/


/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
элементов массива.

[3 7 22 2 78] -> 76



int [] CreatRandomArray (int size, int minValue, int maxValue)
{
   
    int[] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);         
          
    }
    
    return newArray;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
    
}
int Max (int[] array)
{
    int max = array [0];

    for (int i = 1; i < array.Length; i++)
    
    if (max < array [i]) max = array [i];
    
    
    return max;

}
int Min (int[] array)
{
    int min = array [0];
    for (int i = 1; i < array.Length; i++)
   
    if (min > array [i]) min = array[i];
    
    return min;

}

Console.Write("Input the array size: ");
int usersize = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the maxValue: ");
int userMax = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the minValue: ");
int userMin = Convert.ToInt32(Console.ReadLine());

int[] userArray = CreatRandomArray (usersize, userMin, userMax);
ShowArray(userArray);
int maxMax = Max(userArray);
int minMin = Min(userArray);

int result = maxMax - minMin;
Console.Write($"The difference between {maxMax} and {minMin} is {result}");

Console.WriteLine();

*/
