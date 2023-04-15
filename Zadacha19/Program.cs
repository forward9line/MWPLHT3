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






/*{
    Console.WriteLine($"{d} -> {array[2]}");
}
else
{
    Console.WriteLine("числа нет");
}
*/