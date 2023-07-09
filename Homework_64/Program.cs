/*
Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
Console.Clear();
void PrintNumber(int Number)
{   
    int N = 8;
    if (Number < N)
    {
        PrintNumber(Number + 1); 
    }
    Console.WriteLine(Number); 
}
PrintNumber(1);