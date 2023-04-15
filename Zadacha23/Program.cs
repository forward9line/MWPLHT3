/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.WriteLine("Введите число N: ");
Console.Write("N = ");
int n = int.Parse(Console.ReadLine());

GetArrayPow2(n);

void GetArrayPow2(int n)
{
    for (int i = 1; i <= n; i++)
    {
        if (i == n)
        {
            Console.Write(i * i * i);
            break;
        }
        else
        {
            Console.Write($"{i * i * i}, ");
        }


    }
}


