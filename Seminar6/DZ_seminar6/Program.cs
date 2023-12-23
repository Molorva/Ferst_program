// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.
// a b c => “abcdef”
// d e f 

// char[,] elements = new char[2, 3]
// {
//     {'a', 'b', 'c'},
//     {'d', 'e', 'f'}
// };


// string GetString()
// {
//     string result = "";
//     for (int i = 0; i < elements.GetLength(0); i++)
//     {
//        for (int j = 0; j < elements.GetLength(1); j++)
//        {
//         result+= elements[i,j];
//        }
//     }
//     return result;
// }

// System.Console.WriteLine(GetString());






// Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные. 
// “aBcD1ef!-” => “abcd1ef!-”

// string str = "aBcD1ef!-";
// str = str.ToLower(); // метод ToLower() делает все симфолы строчными, а метод ToUpper() делает все симфолы заглавными
// System.Console.WriteLine(str);



// Задайте произвольную строку. Выясните,
// является ли она палиндромом.
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

// System.Console.WriteLine("введите строку");
// string userInput = Console.ReadLine();

// void GetPalindrom()
// {
//     int count = 0;
//     for (int i = 0; i < userInput.Length / 2; i++)
//     {
//         if(userInput[i]==userInput[userInput.Length-i-1]) count++;
//     }
//     if(count ==userInput.Length / 2) System.Console.WriteLine("Да");
//     else System.Console.WriteLine("Нет");
// } 
// GetPalindrom();



// Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.
// “Hello my world” => “world my Hello”

string str = "Hello my world";


string GetResult()
{
    string result = "";
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == " ")
        {
           while (count <i)
           {
            result = str[count] + result;
            count++;
           } 
        }
        count = i;
    }
    return result;
}