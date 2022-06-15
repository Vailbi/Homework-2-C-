Console.WriteLine("Введите 1-ое число");
int inputNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число");
int inputNumber2 = Convert.ToInt32(Console.ReadLine());


if (Sqrt(inputNumber1) == inputNumber2 || Sqrt(inputNumber2) == inputNumber1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

int Sqrt (int x)
{
    return x*x;
}