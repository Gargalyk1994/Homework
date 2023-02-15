// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine());
int[] array = {1, 2, 3, 4, 5, 6, 7, 8};
int size = 8;
int index = 0;

while (index < size)
{
    if (array[index] % 2 == 0)
    {
       Console.Write(array[index]); 
    }
    else if (array[index] % 2 == 1)
    {
        Console.Write(",");
    }
    index= index + 1;
}

