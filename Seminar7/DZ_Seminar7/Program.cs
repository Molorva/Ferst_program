// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
//  Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 

// int M = new Random().Next(1, 5);
// int N = new Random().Next(5, 10);

// System.Console.WriteLine("Число М = " + M);
// System.Console.WriteLine("Число N = " + N);
// PrintNumbers(M, N);

// void PrintNumbers(int firstEl, int endEl)
// {
//     System.Console.WriteLine(firstEl);
//     if (firstEl == endEl)
//     {
//         return;
//     }

//     PrintNumbers(firstEl + 1, endEl);
// }





// Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

// A(m,n) = n+1, если m=0
// A(m,n) = A(m-1,1), если m>0 и n=0
// A(m,n) = A(m-1,A(m,n-1)), если m>0 и n>0

// int m = new Random().Next(0, 4);
// int n = new Random().Next(0, 4);

// System.Console.WriteLine("Число m = " + m);
// System.Console.WriteLine("Число n = " + n);

// int AkkermanFunc(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     if (m > 0 && n == 0)
//     {
//         return AkkermanFunc(m - 1, 1);
//     }
//     return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
// }
// System.Console.WriteLine(AkkermanFunc(m, n));



// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int[] array = new int[4];

void PrintArray(int[] arr, int i)
{
    if (i == arr.Length)
    {
        return;
    }
    array[i] = new Random().Next(1, 10);
    System.Console.Write(array[i] + " ");
    PrintArray(arr, i + 1);

}


void GetNewArray(int[] arr, int i)
{
    System.Console.Write(array[arr.Length - 1 - i] + " ");
    
    if(i==arr.Length-1)
    {
        return;
    }

    GetNewArray(arr, i + 1);
}


PrintArray(array, 0);
System.Console.WriteLine();
GetNewArray(array,0);