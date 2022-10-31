//ДЗ 1
//ДЗ Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
/*
Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int quad2 = n2* n2;

if(quad2 == n1)
    Console.WriteLine($"Number {n1} is a square of {n2}");
else
    Console.WriteLine($"Number {n1} is not a square of {n2}");
*/

//ИЗ ВИДЕО!!! Задача 2. 
/*
Console.Write("Input a positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while(current <= number)
{
    Console.Write(current + " ");
    current++;
}
*/
//ДЗ Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Input a first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input third number: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine("Максимальное число: " + firstNumber);
    }
    else
    {
        Console.WriteLine("max number: " + thirdNumber);
    }
}

else if (secondNumber > thirdNumber)
{
    Console.WriteLine("max number: " + secondNumber);
}
else
{
    Console.WriteLine("max number: " + thirdNumber);
}
*/
// ИЗ ВИДЕО!!!Задача 3. 
/*
Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number % 10;
Console.WriteLine($"Last digit of {number} is {result}");
*/
//ДЗ Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());
    if (a % 2 == 0) 
        {
            Console.WriteLine("Четное");
        }
        else Console.WriteLine("Нечетное");
        {
            Console.WriteLine();
        }
*/

//ДЗ Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите  число:");
int n;
n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)            
 {if (i % 2==0)
    {
        Console.Write(i + " ");
    }
 }
