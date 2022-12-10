// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumber (int num)
{
    int sum = 0;
    while (num >= 1)
    {
        sum += num%10;
        num/=10;
    }
    return sum;
}

Console.WriteLine("Введите число num ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма введенного числа {num} -> {SumNumber(num)}");
