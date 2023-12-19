// Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Console.WriteLine("Введите индекс строки");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите индекс столбца");
// int y = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[4, 5];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void FindNum()
// {
//     if (x > array.GetLength(0) || y > array.GetLength(1)) Console.WriteLine("Такого элеента нет");

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == x && j == y) Console.WriteLine(array[i, j]);
//         }
//     }
// }

// CreateArray();
// PrintArray();
// FindNum();



// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// int[,] array = new int[5, 6];

// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void NewArray()
// {
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         int temp = array[0, i];
//         array[0, i] = array[array.GetLength(0) - 1, i];
//         array[array.GetLength(0) - 1, i] = temp;
//     }
// }
// CreateArray();
// PrintArray();
// NewArray();
// PrintArray();


// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// int[,] array = new int[3, 6];
// int[] array2 = new int[array.GetLength(0)];
// void CreateArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void FindSum()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         array2[i] = sum;
//     }
// }

// void FindMin()
// {
//     int min = array2[0];
//     int minInd = 0;
//     for (int i = 1; i < array2.Length; i++)
//     {
//         if (array2[i] < min)
//         {
//             min = array2[i];
//             minInd = i;
//         }
//     }
//     Console.WriteLine($"Строка с индексом {minInd}");
// }
// CreateArray();
// PrintArray();
// FindSum();
// FindMin();




// Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца

int[,] array = new int[3, 6];
int[,] array2 = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
void FindMin()
{
    int min = array[0, 0];
    int x = 0;
    int y = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                x = i;
                y = j;
            }
        }
    }

    for (int i = 0; i < array.GetLength(1); i++)
    {
        array[x, i] = 0;
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, y] = 0;
    }
}

void CreateArray2()
{
    int h = 0;
    int t = 0;

    for (int i = 0; i < array.GetLength(0); i++) // здесь нужно выпускать каким-то образом нолики и перепрыгивать на другую строчку или следующий символ и записывать это все в новый массив
    {

        int t = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (array[i, j] == 0)
            {
                if (array[i, j + 1] == 0)
                {
                    j++:
                }
                i++;
            }
            array2[h, t] = array[i, j];
            t++;
        }
            h++;
    }
    
}
void PrintArray2()
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write(array2[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}


CreateArray();
PrintArray();
FindMin();
PrintArray();
CreateArray2();
PrintArray2();
