﻿// Напишите программу, которая принимает на вход три числа 
// и выдaет максимальное из этих чисел

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(a > max) {
    max = a;
}
else if(b > max) {
    max = b;
}
else if(c > max) {
    max = c;
}

Console.WriteLine("max = " + max);