// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//i = 4, j = 2 -> такого числа в массиве нет
//i = 1, j = 2 -> 2

//Действие третье - вызов
Console.Write("Введите число строк:\t");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов:\t");
int columns = int.Parse(Console.ReadLine()!);

int[,] massiv = GetArray2mmass(rows, columns, 0, 9);
NewMass2mer(massiv);

Console.Write("Введите номер строки элемента массива i:\t");
int ipoz = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер столбца элемента массива j:\t");
int jpoz = int.Parse(Console.ReadLine()!);

  

 if (ipoz < 0 | ipoz > massiv.GetLength(0) - 1| jpoz < 0 | jpoz > massiv.GetLength(1) - 1 )
 {
                
                Console.WriteLine($"На позиции i = {ipoz}; j ={jpoz} ==> элемент не существует");
            }
  else
  {
    Console.Write($"На позиции i = {ipoz}; j ={jpoz} находится элемент ==> {massiv[ipoz, jpoz]}");
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
