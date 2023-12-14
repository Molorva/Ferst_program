// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 101);
//     System.Console.Write(array[i] + " ");
// }

// System.Console.WriteLine();
// int result = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] < 91 && array[i] > 19)
//     {
//         result = result +1;
//     }
// }
// System.Console.WriteLine(result);





// Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

// int[] array = new int [10];
// for(int i =0; i<array.Length; i++)
// {
//     array[i] = new Random().Next();
//     System.Console.Write(array[i] + " ");
// }

// System.Console.WriteLine();
// int result = 0;

// for(int i =0; i<array.Length; i++)
// {
//     if(array[i]%2 == 0)
//     {
//         result = result +1;
//     }
// }
// System.Console.WriteLine(result);





// Задайте массив из вещественных чисел с НЕнулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

// double[] array = new double [5];
// for(int i =0; i<array.Length; i++)
// {
//     array[i] = new Random().NextDouble();
//     System.Console.Write(array[i].ToString("F3") + " ");
// }

// System.Console.WriteLine();

// double max = array[0];
// double min = array[0];

// for(int i =0; i<array.Length; i++)
// {
//     if(array[i] > max)
//     {
//         max = array[i];
//     }

//     if(array[i]< min)
//     {
//         min = array[i];
//     }
// }

// double result = max - min;
// System.Console.WriteLine(result.ToString("F3"));





// Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа.
// Старший разряд числа должен располагаться на 0-м индексе массива, 
// младший – на последнем. Размер массива должен быть равен количеству цифр.

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 1 && num < 100001)
{
    string str = num.ToString(); // переводим число в  строку
    int length = str.Length; //  подсчитываем сколько в числе разрядов(длинну строки/количество символов)

    int x = 10;
    int y = 1;
    while (y < length - 1) // получаем делитель для получения самого левого разряда
    {
        x = x * 10;
        y++;
    }

    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = num / x;
        num = num % x;
        x = x / 10;
        System.Console.Write(array[i] + " ");
    }
}
else
{
    System.Console.WriteLine("Число не подходит");
}

