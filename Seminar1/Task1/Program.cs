// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите два числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a > b) {
    Console.WriteLine("Первое число больше второго");
}
else {
    if (a == b) {
    Console.WriteLine("Числа равны, запустите программу еще раз (в задаче не указано требование что числа не должны быть равны)");
    }
    else { Console.WriteLine("Второе число больше первого");
    }
}
Console.WriteLine("Конец программы");