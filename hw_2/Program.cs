// Напишите программу, которая принимает на вход три числа 
// и выдaет максимальное из этих чисел

int a = 44;
int b = 5;
int c = 78;

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