// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
string randomNumber = Console.ReadLine();

if (randomNumber.Length > 2)
{
    Console.WriteLine($"Третьей цифрой числа {randomNumber} является {randomNumber[2]}");
}
else
{
    Console.WriteLine($"В числе {randomNumber} меньше трех цифр");
}