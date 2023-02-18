// Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int index = 1;

while(index <= N) {
    if(index % 2 == 1) {
        index++;
    }
    else {
        Console.Write(index + " ");
        index ++;
    }
}