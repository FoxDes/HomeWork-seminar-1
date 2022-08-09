// Напишите программу, которая на входе принимает два числа и выдает какое число больше а какое меньше
int a = 1;
int b = 6;

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