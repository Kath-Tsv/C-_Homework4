// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Task27 (number);

void Task27(int value)
{
    int temp = value;
    int sum = 0;
    while (temp > 0)
    {
        sum = sum + temp%10;
        temp = temp/10;
    }
      Console.WriteLine($"Сумма цифр числа {value} равна: {sum}");
}
