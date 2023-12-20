// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.



using System;

class Program
{
    static void Main()
    {
        // Создаем двумерный массив 
        int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Запрашиваем у пользователя позиции элемента
        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int column = int.Parse(Console.ReadLine());

        // Получаем значение элемента по заданным позициям с использованием пользовательского метода GetElementValue
        // то есть Получаем значение элемента массива
        int result = GetElementValue(array, row, column);

        // Выводим результат
        if (result != int.MinValue)
        {
            Console.WriteLine($"Значение элемента на позиции ({row}, {column}): {result}");
        }
        else
        {
            Console.WriteLine($"Элемента на позиции ({row}, {column}) не существует.");
        }
    }

    static int GetElementValue(int[,] array, int row, int column)
    {
        // Получаем количество строк и столбцов в массиве
        int numRows = array.GetLength(0);
        int numColumns = array.GetLength(1);

        // Проверяем, что заданные позиции находятся в пределах массива
        if (row >= 0 && row < numRows && column >= 0 && column < numColumns)
        {
            // Возвращаем значение элемента по заданным позициям
            return array[row, column];
        }
        else
        {
            // Возвращаем специальное значение (int.MinValue), чтобы указать, что элемента не существует
            return int.MinValue;
        }
    }
}