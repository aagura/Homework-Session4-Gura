//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))//23
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
int sumNumber (int number)
{
 string stringNumber = Convert.ToString (number);
 int result = 0;
 for (int i = 0 ; i < stringNumber.Length ; i++)
 {
      result= result + stringNumber[i]-'0';
 }
 return result;
}

int number = GetNumber ("Введите число");


Console.WriteLine ($"Сумма цифр числа {number} равна {sumNumber (number)}");