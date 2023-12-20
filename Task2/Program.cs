// Задача 2: 
// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.



class Program
{
    static void Main()
    {
        // Задаем двумерный массив (3x3 в данном случае)
        int[,] twoDimensionalArray = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Выводим исходный массив на экран
        Console.WriteLine("Исходный массив:");
        DisplayArray(twoDimensionalArray);

        // Меняем местами первую и последнюю строки массива
        SwapRows(twoDimensionalArray, 0, twoDimensionalArray.GetLength(0) - 1);  //МенятьМестамиСтроки(двумерныйМассив, 0, двумерныйМассив.GetLength(0) - 1);

        // Выводим измененный массив на экран
        Console.WriteLine("\nМассив после замены:");
        DisplayArray(twoDimensionalArray);
    }

    // Метод для вывода двумерного массива на экран
    static void DisplayArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Выводим элемент массива на консоль
                Console.Write(array[i, j] + " ");
            }
            
            // Переходим на новую строку после вывода всех элементов в текущей строке
            Console.WriteLine();
        }
    }

    // Метод для замены местами двух строк в двумерном массиве
    static void SwapRows(int[,] array, int firstRow, int secondRow)  //static void МенятьМестамиСтроки(int[,] массив, int перваяСтрока, int втораяСтрока)
    {
        int cols = array.GetLength(1);

        for (int j = 0; j < cols; j++)
        {
            // Используем временную переменную для обмена значениями
            int tempVariable = array[firstRow, j];   //int временнаяПеременная = массив[перваяСтрока, j];
            array[firstRow, j] = array[secondRow, j];  //массив[перваяСтрока, j] = массив[втораяСтрока, j];
            array[secondRow, j] = tempVariable;  //массив[втораяСтрока, j] = временнаяПеременная;
        }
    }
}