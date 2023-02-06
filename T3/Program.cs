//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result)) 
        {
            break;
        }
        
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }

    return result;
}

int  [] inputarray ()
{
int [] array = new int [8];
for (int i = 0 ; i < array.Length ; i++)
{
array [i] = GetNumber($"Введите элемент {i}");
}
return array;
}

void  printarray (int [] array)
{
Console.Write ("[");
for (int i = 0 ; i < array.Length-1 ; i++)
{
Console.Write ($"{array[i]},");
}
Console.Write ($"{array[array.Length-1]}]");
}


int [] array = inputarray ();
printarray (array); 