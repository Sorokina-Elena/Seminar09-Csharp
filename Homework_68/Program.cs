/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

double FindFunction(double m, double n){
    
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return FindFunction(m - 1, 1);
    
    if (m > 0 && n > 0) return FindFunction(m-1, FindFunction(m, n-1));
    return FindFunction(m, n);
}
Console.WriteLine(FindFunction(3, 2));

