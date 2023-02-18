// Напишите программу, которая на вход принимает два числа и выдает, 
// какое число больше, а какое меньше

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int max;
int min;

if(a > b) {
    max = a;
    min = b;
}
else {
    max = b;
    min = a;
}

Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);
