/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/




Console.WriteLine("Введите от 5 символов, а программа проверит является ли строка полиндромом:");
string d = Console.ReadLine();
char[] array = d.ToCharArray();

int e = array.Length;

int i = 0;
char[] array1 = d.ToCharArray();


if (e == 5)
{
   // array1[i] = array[e-1];
   while (e > 0)
    {
        array1[i] = array[e-1];
       
        e--;
        i++;
        
    }
    
    if (array[0] == array1[0])
    {
        if (array[1] == array1[1])
        {
            if (array[2] == array1[2])
            {
                if (array[3] == array1[3])
                {
                    if (array[4] == array1[4])
                    {
                        Console.Write(array);
                        Console.Write(" -> да");
                    }
                    else
                    {
                        Console.Write(array);
                        Console.Write(" ->нет");
                    }
                }
                else
                {
                    Console.Write(array);
                    Console.Write(" ->нет");
                    
                    
                }

            }
            else
            {
                Console.Write(array);
                Console.Write(" ->нет");
            }
        }
        else
        {
            Console.Write(array);
          Console.Write(" ->нет");  
        }
    }
 
    else
    {
        Console.Write(array);
        Console.Write(" ->нет");
    }
    
}
else
{
    Console.WriteLine("Введено неверное количеситво сиволов");
}





/* Решение преподавателя
int number = int.Parse(Console.ReadLine());
bool result = CheckPolindrom(number);
Console.WriteLine(result);
bool CheckPolindrom(int number)
{
    int[] array = ConvertToArray(number);
    int[] reverseArray = ReverseArray(array);
    bool result = Equals(array, reverseArray);
    return result;
}
void PrintArray(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
bool Equals(int[] array1, int[] array2)
{
    if (array1.Length != array2.Length)
    {
        return false;
    }
    for (var i = 0; i < array1.Length; i++)
    {
        if (array1[i] != array2[i])
        {
            return false;
        }
    }
    return true;
}
int[] ReverseArray(int[] array)
{
    int[] result = new int[array.Length];
    for (var i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - 1 - i];
    }
    return result;
}
int[] ConvertToArray(int number)
{
    int length = GetLengthNumber(number);
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = number % 10;
        number = number / 10;
    }
    return result;
}
int GetLengthNumber(int number)
{
    int length = 0;
    while (number != 0)
    {
        number = number / 10;
        length++;
    }
    return length;
}*/