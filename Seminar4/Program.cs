// задайте массив из N случайных чисел(вводтся с клавиатуры). 
//Найдите количесвто чисел, которые оканчиваются на  1 и деляться нацело на 7


// тип возвращающего значения + Название +() + {}

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[num];

// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(10, 101);
//         System.Console.Write(array[i] + " ");
//     }
// }

// int FindNum()
// {
//     int countNum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 10 == 1 && array[i] % 7 == 0)
//         {
//             countNum++;
//         }
//     }
//     return countNum;
// }
// PrintArray();
// int result = FindNum();

// System.Console.WriteLine("\n" + result); // "\n" - выводится с новой строчки





// заполните массив на N (вводится с консоли, не  более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр 
// массива. Старший разряд числа находится  на 0-м индексе,
// младший - на последнем.


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[num];

// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }


// int GetNum()
// {
//     string numberPerson = "";
//     for (int i = 0; i < array.Length; i++)
//     {
//         numberPerson = numberPerson + array[i];
//     }
//     int result = Convert.ToInt32(numberPerson);
//     return result;
// }
// PrintArray();
// int newNum = GetNum();

// System.Console.WriteLine("\n" + newNum);




// Задайте одномерный массив,
// заполненный слчайными числами. Определите количество
// простых чисел в этом массиве.


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[num];

// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(10, 100);
//         System.Console.Write(array[i] + " ");
//     }
// }


// int GetNum()
// {
//     int countNum = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         bool isFind = false;

//         for (int j = 2; j < array[i]; j++)
//         {
//             if (array[i] % j == 0)
//             {
//                 isFind = true;
//             }
//         }
//         if (isFind == false)
//         {
//             countNum++;
//         }
//     }

//     return countNum;
// }

// PrintArray();

// System.Console.WriteLine(GetNum());
