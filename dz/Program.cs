// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int number = new Random().Next(100, 999);
Console.WriteLine("Трехзначное число: " + number);
string result = Convert.ToString(number / 100);
result += Convert.ToString(number % 10);
Console.WriteLine("Трехзначное число без средней цифры: " + result);

// разделитель
Console.WriteLine("----------------------------------------------------");

// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int number2 = int.Parse(Console.ReadLine());
int index = 0;
int col = Convert.ToString(number2).Length;
while (index < col)
{
    if (number2 / 100 == 0)
    {
        Console.WriteLine("Третьей цифры нет.");
        break;
    }
    else
    {
        if (number2 / 1000 == 0)
        {
            Console.WriteLine("Третья цифра: " + number2 % 10);
            break;
        }
        else
        {
            number2 = number2 / 10;
        }
    }
    index++;
}
// разделитель
Console.WriteLine("----------------------------------------------------");

// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите номер дня недели: ");
int number3 = int.Parse(Console.ReadLine());
if ((number3 == 6) | (number3 == 7))
{
    Console.WriteLine("Да, выходной.");
}
else
{
    Console.WriteLine("Нет, будний.");
}