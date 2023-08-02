// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите три числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

/* if (a > b) {
int b = int.Parse(Console.ReadLine());
}
else {
    int a = int.Parse(Console.ReadLine());
}
if (a > b) {
    Console.WriteLine($"наибольшее число равно {a}");
}
else {
    Console.WriteLine($"наибольшее число равно {b}");
}
Нельзя периначивать переменные внутри ветвления,
попробуем по-другому
*/


/*if (a > b) {}
else {
    a = b;
}
int b = int.Parse(Console.ReadLine());
if (a > b) {
    Console.WriteLine($"наибольшее число равно {a}");
}
else {
    Console.WriteLine($"наибольшее число равно {b}");
}
И даже не в области вевтления нельзя переиначить переменную,
которую уже обозначили в облсти программы, 
поэтому требуется определить третью переменную
*/

int c = int.Parse(Console.ReadLine());
if (a > b) {}
else {a = b;}
if (a > c) {
     Console.WriteLine($"наибольшее число равно {a}");
}
else  Console.WriteLine($"Наибольшее число равно {c}");
Console.WriteLine("Конец программы");
