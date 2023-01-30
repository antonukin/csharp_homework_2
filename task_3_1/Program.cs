// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число обозначающее день недели");
string dayNum = Console.ReadLine();
int num = Convert.ToInt32(dayNum) - 1;
string[] week = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };

if(num <= 5)
{
    Console.WriteLine($"{week[num]} это будний день");
}
else
{
    Console.WriteLine($"{week[num]} это выходной день");
}