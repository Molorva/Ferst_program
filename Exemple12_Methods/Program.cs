// // // вид 1 - ничего не принимают и ничего не возвращают
// // void Method1()
// // {
// //     System.Console.WriteLine("Автор Molorva");
// // }
// // //Method1();

// // // Вид2 - ничего не возвращают, но принимают аргументы
// // void Method2(string msg)
// // {
// //     System.Console.WriteLine(msg);
// // }
// // //Method2("Текст сообщения");

// // void Method2_1(string msg, int count)
// // {
// //     int i = 0;
// //     while (i < count)
// //     {
// //         Console.WriteLine(msg);
// //         i++;
// //     }
// // }
// // //Method2_1("Текст", 4); // вот так лучше
// // //Method2_1(count: 4, msg: "новый текст"); // можно написать в любом порядке, но гораздо проще писать сначаал msg, а затем count, т.к. тогда подсьавляется все автоматичски)

// // // Вид3 - ничего не принимает, но возвращает  аргументы

// // int Method3()
// // {
// //     return DateTime.Now.Year;
// // }
// // int year = Method3();
// // //Console.WriteLine(year);


// // // Вид 4 - принимает и возвращает аргументы

// // // string Method4(int count, string text)
// // // {
// // //     int i = 0;
// // //     string result = String.Empty; // изначальное значение - пустая строка

// // //     while(i<count)
// // //     {
// // //         result = result+text;
// // //         i++;
// // //     }
// // //     return result;
// // // }
// // // string res = Method4(10, "asdj ");
// // // Console.WriteLine(res);

// // //  Вид 4 с циклом for
// // string Method4(int count, string text)
// // {

// //     string result = String.Empty; // изначальное значение - пустая строка
// //     for (int i = 0; i < count; i++)
// //     {
// //         result = result + text;
// //     }
// //     return result;
// // }
// // string res = Method4(10, "asdj ");
// // Console.WriteLine(res);

// // //вывод таблицы умножения на экран
// // for(int i = 2; i<= 10; i++)
// // {
// //     for(int j = 2; j<=10; j++)
// //     {
// //         Console.WriteLine($"{i} x {j} = {i*j}");
// //     }
// //     Console.WriteLine();
// // }

// // //=========Работа с текстом
// // //Дан текст. В тексте нужно все пробелы заменить черточками,
// // //Маленькиебуквы "k" заменить большими "K",
// // //А большие "C" заменить маленькими "c".

// // //Ясна ли задача?

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
// + "ежели бы вас послали вместо нашего милого Винценгероде,"
// + "вы бы взяли пристопом согласие прусского короля."
// + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int lehgth = text.Length;
//     for (int i = 0; i < lehgth; i++)
//     {
//         if (text[i] == oldValue) result= result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);

// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);




int[] arr = { 1, 5, 4, 3, 6, 7, 1, 1 };

void PrintArray(int[] array) // функция для выведения на экран любого массива
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) //функция для сортироваки от меньшего к большему
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}

PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);


// СР (самостояельная работа) фкнкция, сортирующая от большего к меньшему 
void SortMaxMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }


        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;

    }
}
SortMaxMin(arr);
PrintArray(arr);