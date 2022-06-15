Console.WriteLine("Введите число от 1 до 7");
int inputNumber = Convert.ToInt32(Console.ReadLine()); // Проверка дней недели
if (inputNumber ==6 || inputNumber ==7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}