// Задача 25. Напишите цикл,который принимает на вход два числа (А и B) и возвращает число А в натуральную степень B.
// 3;4 -> 243  ;   2;4 -> 16.
/*
Console.Write("Input a first-degree number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second-degree number: ");
int b  = Convert.ToInt32(Console.ReadLine());

{
    int result = 1; 
    for(int i =1; i<=b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}
*/

// Задача 27. Напишите программу,которая принимает на вход число и выдает сумму цифр в цикле.
// 452-> 11 ;  82-> 10 ;   9012-> 12
/*
     static void Main(string[] args)
    {
        int num, sum = 0, r;
        Console.WriteLine("Enter a Number : ");
        num = int.Parse(Console.ReadLine());
        while (num != 0)
        {
            r = num % 10;
            num = num / 10;
            sum = sum + r;
        }
        Console.WriteLine("Sum of Digits of the Number : "+sum);
        Console.ReadLine();
    }
 */

// Задача 29. Напишите программу,которая задает массив из элементов   и выдает их на экран .
// 1,2,5,7,19 -> [1,2,5,7,19]
/*       
//             0,1,2,3,4
int[] array = {1,2,5,7,19};

void PrintArray(int[] arr)
{
    int count  = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(array);
*/


 

  