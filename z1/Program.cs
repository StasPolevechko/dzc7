/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

int Prompt(string message)
{
    System.Console.Write(message);
    string value = System.Console.ReadLine() ?? "";
    int result = Convert.ToInt32(value);
    return result;
}


int[,] InputArray(int line, int column, int minValue, int maxValue)
{
    int[,] array = new int[line, column];

    Random ran = new Random();

       for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = ran.Next(minValue, maxValue);
            Console.Write("{0}\t", array[i, j]);
        }
        Console.WriteLine();
    }
     return array;
}



int line = Prompt("количество строк в массиве: ");
int column = Prompt("количество столбцов в массиве: ");
int min = Prompt("минимальное значение массива: ");
int max = Prompt("максимальное значение массива: ");
int[,] array;
array = InputArray(line, column, min, max);
