//ДЗ 1
//Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2* n2;

if(quad2 == n1)
    Console.WriteLine($"Number {n1} is a square of {n2}");
else
    Console.WriteLine($"Number {n1} is not a square of {n2}");
