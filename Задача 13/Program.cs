Console.WriteLine("Введите число");
int inputNumber = Convert.ToInt32(Console.ReadLine());  // **нахождение 3 числа**

if (inputNumber < 100)
{
    Console.WriteLine("Третий цифры нет");
}
else
{
    
    while(inputNumber > 999)
    {
        inputNumber = inputNumber/10;

    }
 
Console.WriteLine(inputNumber%10);
}