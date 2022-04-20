Console.WriteLine("Введите первое число: ");
int num = int.Parse(Console.ReadLine());
int num1 = 7;
int num2 = 23;
if ((0 == num % num1) | (0 == num% num2))
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("не кратно");
}