/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();
int SumNumber(int M, int N)
{   
    if (M == N+1) return 0;
    {
        return M + SumNumber(M + 1, N); 
    }
}
Console.WriteLine(SumNumber(1, 15));



