﻿// Напишите программу, которая на вход принимает число и выдает, является ли число четным

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a % 2==1) {
    Console.WriteLine("Число нечетное");
}
else {
     Console.WriteLine("Число четное");
}