// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int i=1;
if (a == 0 || a<0) {
    Console.WriteLine("Заданное число задано некорректно, однако в условии не указано что делать, если заданное число равно нулю или меньше нуля");
}
else {
if (i == a) {
    Console.WriteLine(i);
}
else {
    Console.Write(i);
    i++;
while (i <= a) {
    Console.Write($" {i}");
    i=i+2;
}
Console.WriteLine("");
}
}
Console.WriteLine("Конец программы");