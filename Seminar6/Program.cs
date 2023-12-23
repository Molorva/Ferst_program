// char [] elements = new char[]{'$', '2', 'F'};
// string str = "$2f";
// System.Console.WriteLine(str[0]);

// Задайте массив символов ( тип char[]). Создайте строку из
// символов  этого массива.
//указание
// Конструктор строки вида string(char[]) не использовать.

// char[] elements = new char[] { 't', '8', '4' };
// string GeStringFromArray()
// {
//     string str = "";

//     for (int i = 0; i < elements.Length; i++)
//     {
//         str += elements[i];
//     }
//     return str;
// }

// // string result = GeStringFromArray();
// // System.Console.WriteLine(result);
// System.Console.WriteLine(GeStringFromArray());


// на основе симофольной строки (тип string) сформировать массив
// симфолов (типа char[]). Вывести массив на экран.
//Указание
//Метод строки ToCharArray() не использовать.
//пример
// "Hello!" => ['H', 'e', 'l', 'l', 'o', '!']

// System.Console.WriteLine("Введите строчку");
// string userInput = Console.ReadLine();

// char[] elements = new char[userInput.Length];

// void GetArrayFromString()
// {
//     for (int i = 0; i < elements.Length; i++)
//     {
//         elements[i] = userInput[i];
//     }
    
// }

// void PrintArray()
// {
//     foreach (char item in elements) // работает без индекса, просто перебирает кажды элемент подряд
//     {
//         System.Console.Write(item + " ");
//     }
// }

// GetArrayFromString();
// PrintArray();

// Считать строку с консоли, состоящую из латинских
//букв в нижнем регистре. Выяснить, сколько среди 
// введенных букв гласных.
//Пример
// "hello" => 2
//"world" = > 1

// System.Console.WriteLine("введите строку");
// string userInput = Console.ReadLine();

// string vowels = "eyuioa";

// int GetCountVowels()
// {
//     int count = 0;
//     for (int i = 0; i < userInput.Length; i++)
//     {
//         for (int j = 0; j < vowels.Length; j++)
//         {
//             if(userInput[i]==vowels[j])
//             {
//                 count++;
//             }
//         }
//     }
//     return count;
// }

// System.Console.WriteLine(GetCountVowels());