/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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
void EverageColum(int[,] array, int line, int column)
{
   // double everage = 0;
    for (int j = 0; j < column; j++)
    {
        double sum = 0;
        for (int i = 0; i < line; i++)
        {
            sum = sum + array[i, j];

        }
        double everage = sum / line;

        System.Console.Write($"{everage}; ", " ");
    }
}




int line = Prompt("количество строк в массиве: ");
int column = Prompt("количество столбцов в массиве: ");
int min = Prompt("минимальное значение массива: ");
int max = Prompt("максимальное значение массива: ");
int[,] array;
array = InputArray(line, column, min, max);
EverageColum(array, line, column);