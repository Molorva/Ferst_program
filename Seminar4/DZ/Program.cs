// Напишите программу, которая бесконечно запрашивает 
// целые числа с консоли. Программа завершается при вводе 
// символа ‘q’ или при вводе числа, сумма цифр которого чётная.


// int x = 0;
// while (x == 0) // Бесконечный цикл
// {
//     Console.Write("Введите целое число, для выхода введите 'q' ");
//     string input = Console.ReadLine(); // Чтение строки ввода пользователя
//     if (input == "q") // Проверка на ввод 'q' для выхода
//     {
//         break;
//     }
//     else
//     {
//         int num = Convert.ToInt32(input); // переводим в число
//         int sum = 0;
//         while (num > 0) // считаем сумму
//         {
//             sum = sum + num % 10;
//             num = num / 10;
//         }
//         if (sum % 2 == 0) // проверка суммы на четность
//         {
//             Console.WriteLine("[STOP]");
//             break;
//         }

//     }

// }




// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[num];

// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//         System.Console.Write(array[i] + " ");
//     }
// }


// int GetNum()
// {
//     int countNum = 0; // счетчик для четных чисел
//     for (int i = 0; i < array.Length; i++) //перебираем массив
//     {
//         bool isFind = false;
//         if (array[i] % 2 == 0) isFind = true;
//         if (isFind == true) countNum++;
//     }
//     return countNum;
// }

// PrintArray();
// System.Console.WriteLine("\n" + GetNum());





// Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)



Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
        System.Console.Write(array[i] + " ");
    }
}

void Main()
{
int temp;

// Реверсирование массива
for (int i = 0; i < array.Length / 2; i++)
{
// Меняем местами элементы
temp = array[i];
array[i] = array[array.Length - 1 - i];
array[array.Length - 1 - i] = temp;
}
// Вывод измененного массива
for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}
PrintArray();
System.Console.WriteLine();
Main();