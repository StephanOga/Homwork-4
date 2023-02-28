/* Задача 27: Напишите метод, который 
принимает на вход число и выдаёт 
сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int Promt(string text)
{
    Console.Write(text);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int SumDigit(int num)
{
    int result = 0;
    while(num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

int number = Promt("Введите число ");
Console.WriteLine($"Сумма всех цифр в числе {number} = {SumDigit(number)}");