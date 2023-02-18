// Напишите программу, которая на вход принимает два числа и выдает, 
// какое число больше, а какое меньше

int a = 5;
int b = 9;

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
