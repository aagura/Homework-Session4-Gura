//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

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


int power (int number, int raise)
{
int power = 1;
for (int i = 1; i <= raise; i++ )
{ 
    power = power*number;
} 
  return power;
}
    
int number = GetNumber ("Введите  число");

int raise = GetNumber ("Введите  степень");

Console.WriteLine ($"{number} в степени {raise} равно {power(number,raise)}");
