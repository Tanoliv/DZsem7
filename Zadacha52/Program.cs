// Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//Действие третье - вызов
Console.Write("Введите число строк:\t");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов:\t");
int columns = int.Parse(Console.ReadLine()!);

int[,] massiv = GetArray2mmass(rows, columns, 0, 9);
NewMass2mer(massiv);

Console.Write("Среднее арифметическое каждого столбца: ");

for (int j = 0; j < massiv.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        sum += massiv[i, j];
    }
    Console.Write($"{ sum / massiv.GetLength(0):F2} ");
}    

void NewMass2mer(int[,] mass )
{
    for(int i = 0; i < mass.GetLength(0); i++)
    {
        for(int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write($"{mass[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] GetArray2mmass(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j <n; j++)
        {
             result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
       
    }
    return result;
}

