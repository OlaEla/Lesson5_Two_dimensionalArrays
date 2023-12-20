// Задача 4
// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца


using System;

class Program
{
    static void Main()
    {
        // Создаем двумерный массив из случайных чисел.
        int[,] array = GenerateRandomArray(3, 3, 1, 10);

        // Находим индексы минимального элемента в массиве.
        (int minRow, int minCol) = FindMinElementIndex(array);

        // Создаем новый массив без строки и столбца с минимальным элементом.
        int[,] newArray = RemoveRowAndColumn(array, minRow, minCol);

        // Выводим исходный массив.
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Выводим новый массив без строки и столбца с минимальным элементом.
        Console.WriteLine("\nМассив после удаления строки и столбца с минимальным элементом:");
        PrintArray(newArray);
    }

    // Метод для генерации двумерного массива случайных чисел.
    static int[,] GenerateRandomArray(int rows, int cols, int minValue, int maxValue)
    {
        int[,] randomArray = new int[rows, cols];
        Random random = new Random();

        // Заполняем массив случайными числами в заданном диапазоне.
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                randomArray[i, j] = random.Next(minValue, maxValue);
            }
        }

        return randomArray;
    }
    // Метод для поиска индексов минимального элемента в массиве.
    static (int, int) FindMinElementIndex(int[,] array)
    {
        int minElement = array[0, 0];
        int minRow = 0;
        int minCol = 0;

        // Проходим по всем элементам массива.
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                // Если текущий элемент меньше минимального, обновляем значения минимального элемента и его индексов.
                if (array[i, j] < minElement)
                {
                    minElement = array[i, j];
                    minRow = i;
                    minCol = j;
                }
            }
        }

        // Возвращаем индексы минимального элемента.
        return (minRow, minCol);
    }

    // Метод для удаления строки и столбца из массива.
    static int[,] RemoveRowAndColumn(int[,] array, int rowIndex, int colIndex)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        // Создаем новый массив с уменьшенным размером.
        int[,] newArray = new int[rows - 1, cols - 1];

        // Копируем элементы из исходного массива в новый массив, исключая строку и столбец с минимальным элементом.
        for (int i = 0, newRow = 0; i < rows; i++)
        {
            // Пропускаем удаляемую строку.
            if (i == rowIndex)
                continue;

            for (int j = 0, newCol = 0; j < cols; j++)
            {
                // Пропускаем удаляемый столбец.
                if (j == colIndex)
                    continue;

                // Копируем элемент в новый массив.
                newArray[newRow, newCol] = array[i, j];

                // Увеличиваем индекс нового столбца.
                newCol++;
            }

            // Увеличиваем индекс новой строки.
            newRow++;
        }

        // Возвращаем новый массив.
        return newArray;
    }

    // Метод для вывода двумерного массива на консоль.
    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} \t");
            }
            Console.WriteLine();
        }
    }
} 