// Задача 3: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


using System;

class Program
{
    static void Main()
    {
        // Задаем двумерный массив
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Находим строку с наименьшей суммой элементов
        int minSumRow = FindMinSumRow(matrix);

        // Выводим результат
        Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow}");
    }

    static int FindMinSumRow(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int minSum = int.MaxValue; // Инициализируем минимальную сумму значением int.MaxValue
        int minSumRow = 0; // Индекс строки с минимальной суммой

        for (int i = 0; i < rows; i++)
        {
            int currentSum = 0; // Инициализируем сумму текущей строки

            for (int j = 0; j < cols; j++)
            {
                currentSum += matrix[i, j]; // Прибавляем каждый элемент текущей строки к сумме
            }

            if (currentSum < minSum)
            {
                minSum = currentSum; // Обновляем минимальную сумму
                minSumRow = i; // Запоминаем индекс строки с минимальной суммой
            }
        }

        return minSumRow;
    }
}
