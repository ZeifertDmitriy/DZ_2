// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
if (Convert.ToString(number).Length == 5)
{
    if ((number % 10 == number / 10000) & ((number % 100) / 10 == (number / 1000) % 10))
    {
        Console.WriteLine("Число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом.");
    }
}
else
{
    Console.WriteLine("Введено не пятизначное число.");
}

Console.WriteLine("------------------------------------------");
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int x1 = new Random().Next(1, 10);
int y1 = new Random().Next(1, 10);
int z1 = new Random().Next(1, 10);
int x2 = new Random().Next(1, 10);
int y2 = new Random().Next(1, 10);
int z2 = new Random().Next(1, 10);
//x1 = 3;
//y1 = 6;
//z1 = 8;
//x2 = 2;
//y2 = 1;
//z2 = -7;
double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
Console.WriteLine(result);

Console.WriteLine("------------------------------------------");
// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int index = 1;
while (index < num)
{
    Console.Write(Math.Pow(index, 3) + ", ");
    index++;
}
Console.Write(Math.Pow(index, 3) + ".");