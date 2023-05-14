/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

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
bool ArrayElement(int[,] array, int number, int line, int column)
{
    int lin = 0;
    int col = 0;
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (number == array[i, j])
            {
                lin = i;
                col = j;
                Console.WriteLine($"{i+1} - строка,{j+1}- столбец");
                return false;
                
            }
        }

    }
    return true;

}

int line = Prompt("количество строк в массиве: ");
int column = Prompt("количество столбцов в массиве: ");
int min = Prompt("минимальное значение массива: ");
int max = Prompt("максимальное значение массива: ");

int[,] array;
array = InputArray(line, column, min, max);
int number = Prompt("введите искомое число: ");
if (ArrayElement(array, number, line, column))
{
    Console.WriteLine($"{number} -> нет такого числа в массиве.");

}
