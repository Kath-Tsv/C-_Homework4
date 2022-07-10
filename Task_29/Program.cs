// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
//-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
//6, 1, -33 -> [1, 6, -33]

int size = 8;
int [] array = new int[size];
CreateArray (array);
Console.Write("Массив случайных чисел: ");
PrintArray (array);
SortingArray(array);
Console.Write("Отсортированный по модулю массив: ");
PrintArray (array);

int[] CreateArray(int[] newArray)
{
    Random random = new Random();
    for (int i = 0; i<newArray.Length; i++)
    {
        newArray[i] = random.Next (-10, 11);
    }
    return (newArray);
}

void PrintArray(int[] newArray)
{
    for (int i = 0; i<newArray.Length; i++)
    {
        Console.Write($"{newArray[i]} ");
    }
    Console.WriteLine();
}

int[] SortingArray(int[] newArray)
{
    int temp = 0;

    for (int i = newArray.Length -1; i > 0; i--)
    {
    for (int j = 0; j < i; j++)
    {
       if (Math.Abs (newArray[j]) >  Math.Abs (newArray[j+1])) 
       {
       temp = newArray[j];
       newArray[j] = newArray[j+1];
       newArray[j+1] = temp;
       }
    }
    }
    return (newArray);
    
}


