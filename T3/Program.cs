//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

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

void cub (int number)
{
 int i = 1;
  while (i<number)
  {
    Console.Write (Convert.ToString (Math.Pow (i,3)));
    Console.Write (", ");
    i++;
  }
    Console.Write (Convert.ToString (Math.Pow (number,3)));
}
    
int number = GetNumber ("Введите  число");
cub (number);
