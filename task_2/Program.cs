// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int num = Int32.Parse(number);

if(num / 100 < 1)
{
    Console.WriteLine($"В числе {num} меньше трех цифр");
}
if(num / 100 >= 1)
{
    Console.WriteLine($"Третьей цифрой числа {num} является {num / 100 % 10}");
}