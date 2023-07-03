// Задача №1. Напишите программу, которая на ввод принимает два числа 
// и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

Console.WriteLine("Введите два числа: ");
int numberA = int.Parse(Console.ReadLine()!);
int numberB = int.Parse(Console.ReadLine()!);
// далее, if - указывает, "если ЧТО?", значит у нас должно быть в круглых скобках условие 
// (numberA == numberB * numberB) или (numberB * numberB == numberA). Это одно и тоже.
// Если условие не выполняется, то идёт переход на ветку else.

if (numberA == numberB * numberB)
{ 
    Console.WriteLine("Yes"); 
}
else 
{ 
    Console.WriteLine("No"); 
}

// далее, в терминале dotnet run, 
// и вводим первое число 25 enter, второе число 5 enter
// и программа выдаёт Yes, то есть - всё верно.