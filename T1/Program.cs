//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result)) 
        {
        if (Math.Abs (result) < 9999 || Math.Abs (result) > 99999)     
           {Console.WriteLine("Ввели не пятизначное число. Повторите ввод");
           }
           else 
           {
            break;
           }
        }

        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }

    return result;
}


int reverse (int number)
{
int rev = 0;
int dig = 1;
number = Math.Abs (number);
while(number  > 0)
  { 
    dig =number  % 10;
    rev= rev * 10 + dig;
    number = number / 10;
  }
  return rev;
}
    
int number = GetNumber ("Введите пятизначное число");

int polindrom = reverse (number);

if(Math.Abs (polindrom) == Math.Abs (number))
{
   Console.WriteLine ("Это палиндром!");
}
else
{
  Console.WriteLine ("Это не палиндром!");
}