// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую хотите возвести число: ");
int power = Convert.ToInt32(Console.ReadLine());
Task25 (number, power);

void Task25(int number, int power)
{
    int result = 1;
    for (int i = 1; i<=power; i++)
    {
       result = result * number;
    }
    Console.WriteLine ($"Число {number} в степени {power} будет равно: {result}");
}

