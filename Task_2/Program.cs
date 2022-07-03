// Напишите программу которая на вход принимает позциии элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание что такого элемента нет 

int [,] CreateArray () // Создание массива 
{
    Console.WriteLine("Введите кол-во строк:  ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во строк:  ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    int [,] array = new int [m,n];
    return array;
} 

void FillArray (int [,] array) // Заполнение массива 
{
    for (int i = 0; i < array.GetLength(0); i++) // Переменная i идет по строкам 
    {
        for (int j = 0; j < array.GetLength(1); j++)   // Переменная j идет по столбцам
        {
            array[i,j] = new Random().Next(1,10);
            
        }
    }
}

void PrintArray (int [,] array) // Вывод массива
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

void Element(int [,] array)
{
    Console.Write("Введите номер строки: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int m = Convert.ToInt32(Console.ReadLine());

    if (n > array.GetLength(0) || m > array.GetLength(1))
    {
        Console.WriteLine ("Такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine ($"Число на заданной позиции = {array[(n-1),(m-1)]}");
    }
}



int [,] arr = CreateArray();
FillArray(arr);
PrintArray(arr);
Element(arr);

