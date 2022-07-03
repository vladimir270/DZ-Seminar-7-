// Задайте двумерный массив размером m*x, заполненный случайными вещественными числами



double [,] CreateArray (int n, int m) // Создание массива 
{
    return new double [n,m];
} 

void FillArray (double [,] array) // Заполнение массива 
{
    for (int i = 0; i < array.GetLength(0); i++) // Переменная i идет по строкам 
    {
        for (int j = 0; j < array.GetLength(1); j++)   // Переменная j идет по столбцам
        {
            array[i,j] = Math.Round(((new Random().NextDouble()) * 20 - 10), 1);
            
        }
    }
}

void PrintArray (double [,] array) // Вывод массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}

double [,] arr = CreateArray(3,4);
FillArray(arr);
PrintArray(arr);
