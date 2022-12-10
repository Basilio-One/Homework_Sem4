// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int DegreeNum(int A, int B)
{
    int sum = 1;
    for(int i=1; i <= B; i++)
    sum*=A;
    return sum;
}

Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{A} в {B} степени = {DegreeNum(A, B)}");
