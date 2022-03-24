/*
Задача 1.
Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
*/

Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

int exponentiation(int arg1, int arg2)
{
    int result = 1;
    for (int i = 0; i < arg2; i++)
    {
        result *= arg1;
    }
    return result;
}

if (B < 0) Console.WriteLine("Неверное число. Второе число " +
                             "должно быть больше или ровно 0");
else Console.WriteLine($"Число {A} в степени {B} равно " + 
                        exponentiation(A, B));

/*
Задача 2.
Напишите программу, которая принимает на вход число и выдаёт сумму
цифр в числе.
*/

/*
int num = Convert.ToInt32(Console.ReadLine());

int sumDigits(int arg)
{
    int temp = 0;
    int result = 0;
    while (arg != 0)
    {
        temp = arg % 10;

        if (temp < 0) temp *= -1;

        result += temp;
        arg = arg / 10;
    }
    return result;
}

Console.WriteLine(sumDigits(num));
*/

/*
Задача 3.
Напишите программу, которая задаёт массив из 8 элементов и выводит
их на экран.
*/

/*
int[] makeArray()
{
    int[] arr = new int[8];
    for (int i = 0; i < 8; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
    return arr;
}

void printArray(int[] arg)
{
    Console.Write("[");
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write(arg[i]);
        if (i < arg.Length - 1) Console.Write(", ");
        else Console.WriteLine("]");
    }
}
printArray(makeArray());
*/
