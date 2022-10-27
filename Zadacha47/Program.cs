// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


Console.Write("Введите число строк:\t");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов:\t");
int columns = int.Parse(Console.ReadLine()!);

double[,] massiv = GetArray2mmass(rows, columns, -10, 10);
NewMass2mer(massiv);


void NewMass2mer(double[,] massiv )
{
    for(int i = 0; i < massiv.GetLength(0); i++)
    {
        for(int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i, j]}   ");
        }
        Console.WriteLine();
    }
}


double[,] GetArray2mmass(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];
Random random = new Random( );
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j <n; j++)
        {
             //result[i, j] = Math.Round(random.NextDouble() * 10, 2);
             result[i, j] = Math.Round((maxValue+1 - minValue) *random.NextDouble() + minValue, 2);
        }//double d = p.NextDouble();
       
    }
    return result;
}
