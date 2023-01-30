// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int RandomNumber()
{
    int num = new Random().Next(1, 1000000);
    return num;
}

int number = RandomNumber();

if(number / 100 < 1)
{
    Console.WriteLine($"В числе {number} меньше трех цифр");
}
if(number >= 100 && number < 1000)
{
    Console.WriteLine($"Третьей цифрой числа {number} является {number % 10}");
}
if(number >= 1000 && number < 10000)
{
    Console.WriteLine($"Третьей цифрой числа {number} является {number % 100 / 10}");
}
if(number >= 10000 && number < 100000)
{
    Console.WriteLine($"Третьей цифрой числа {number} является {number % 1000 / 100}");
}
if(number >= 100000 && number < 1000000)
{
    Console.WriteLine($"Третьей цифрой числа {number} является {number % 10000 / 1000}");
}