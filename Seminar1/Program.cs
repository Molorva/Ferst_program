// пользователь должен вводить число, а программа выдавать его квадрат

// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sqr = num*num;
// Console.Write("Квадрат равен ");
// Console.WriteLine(sqr);






// Пользователь вводит два числа, 
// а программа проверяет, не является ли 
// первое число квадратом второго

// Console.WriteLine("Введите число 1 ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число 2 ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == num2 * num2)
// {
//     Console.Write("да");
// }
// else
// {
//     Console.Write("нет");
// }



// пусть программа выдает 
// название дня недели по номеру (3 - среда, 4 - четверг и тд)

// Console.WriteLine("Введите число ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if (num1 == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if (num1 == 2)
// {
//     Console.WriteLine("Вторник");
// }
// else if(num1 == 3)
// {
//     Console.WriteLine("Среда");
// }
// else if (num1 == 4)
// {
//     Console.WriteLine("Четверг");
// }
// else if (num1 == 5)
// {
//     Console.WriteLine("Пятница");
// }
// else if (num1 == 6)
// {
//     Console.WriteLine("Суббота");
// }
// else if (num1 == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
// else
// {
//     Console.WriteLine("Такого дня нет");
// }





//  Пользователь вводит число  N, а программа выдает все целые числа между -N b N


// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// int negNum = num * -1;

// while(negNum<=num)
// {
//     Console.WriteLine(negNum);
//     negNum = negNum+1;
// }




// Пользователь введет трехначное число, 
// а программа покажет последнюю цифру этого числа

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 10;
Console.WriteLine(result);


 