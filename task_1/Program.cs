// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int RandomNumber()
{
    int num = new Random().Next(100, 1000);
    return num;
}

int SecondDigit(int number)
{
    int secDig = number / 10 % 10;
    return secDig;
}

int number = RandomNumber();
int secondDig = SecondDigit(number);
Console.WriteLine($"Дано число {number}, вторая цифра числа {secondDig}");