// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.

int size = 8;
int[]array = new int[size];
array = InputArray(size);
PrintArray(array);

void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("");
} 

int [] InputArray (int size)
{
    int[] array = new int[size];
    for(int i = 0; i <size; i++)
        {
            Console.WriteLine($"Ввести {i + 1} элементов");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        return array;
} 
