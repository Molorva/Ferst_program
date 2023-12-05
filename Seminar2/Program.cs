// // напишите программу, которая на входе получает трехзначное число, а потом удаляет вторую цифру
// // 248 -> 28

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99 && num < 1000) // && - и; || - или
// {
//     // int num1 = num / 100;
//     // int num3 = num % 10;

//     // int result = num1 * 10 + num3;
//     // Console.WriteLine(result);
//     Console.WriteLine((num / 100) * 10 + num % 10);
// }
// else
// {
//     Console.WriteLine("Число не подходит");
// }



// Программа получает на вход трехначное исло и возводит вторую цифру в степень, равноей третьей цифре
// 487 -> 8^7 = 2097152

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine()); //256
// if (num > 99 && num < 1000)
// {
//     int num2 = num / 10 % 10; //5
//     int num3 = num % 10;    //6
//     int result = 1;

//     while (num3 >= 1)
//     {
//         result = result*num2;
//         num3--;
//     }
//     Console.WriteLine(result);
// }
// else
// {
//     Console.WriteLine("Число не подходит");
// }



// Программа на входе получает два числаи выводит, является ли второе число кратным первому
// Если второе число не кратно первоу, то программа выводит остток от деления
// 14 и 5 -> нет, 4
// 10 и 5 -> да
// 4 и 3 -> нет, 1

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1%num2 == 0)
// {
//     Console.WriteLine("да");
// }
// else 
// {
//     // Console.WriteLine("нет, " + num1%num2); // Канкатинация
//     Console.WriteLine($"нет, {num1%num2}"); // Канкатинация
// }



//  Программа выводит третью цифру с конца заданного числа,
// а если такой цифры нет, то сообщает об этом
// 456 -> 4
// 576345 -> 3
// 45 -> Такой цифры нет

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
    if (num > 999)
    {
        num = num % 1000;
    }
    int result = num / 100;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Такой цифры нет");
}