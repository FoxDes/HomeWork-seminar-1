﻿// Напишите программу, которая на входе принимает два числа и выдает какое число больше а какое меньше
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;
int min = b;

if (a > max) max = a;
if (b > max) max = b;
if (a < min) min = a;
if (b < min) min = b;

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);