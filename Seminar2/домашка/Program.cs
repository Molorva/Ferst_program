// Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 7 == 0 && num % 23 == 0)
// {
//     Console.WriteLine("Число одновременно кратно 7 и 23");
// }
// else
// {
//     Console.WriteLine("Число не кратно одновременно 7 и 23");
// }




//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
//в которой находится эта точка.

// Console.WriteLine("Введите число для координаты x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число для координаты y");
// int y = Convert.ToInt32(Console.ReadLine());

// if(x>0 && y>0)
// {
//     Console.WriteLine("1");
// }
// else if (x<0 && y>0)
// {
//     Console.WriteLine("2");
// }
// else if (x<0 && y<0)
// {
//     Console.WriteLine("3");
// }
// else 
// {
//     Console.WriteLine("4");
// }





// Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 10 || num > 99)
// {
//     Console.WriteLine("Число не подходит");
// }
// else
// {
//     int num1 = num / 10;
//     int num2 = num % 10;
//     if(num1>num2)
//     {
//         Console.WriteLine(num1);
//     }
//     else
//     {
//         Console.WriteLine(num2);
//     }
// }





// Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.
// 568 => 5,6,8
// 8 => 8
// 9542 => 9,5,4,2

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine()); //9542

if (num < 10)
{
    Console.WriteLine(num);
}
else
{

    while (num > 0)
    {

        int result = num % 10;
        num = num/10;
        if (num > 0)
        {
            Console.Write(result + ",");
        }
        else
        {
            Console.WriteLine(result);
        }
    }
}