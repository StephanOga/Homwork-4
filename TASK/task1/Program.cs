/* Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Math.Pow использовать нельзя
3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int Promt(string text)
{
    Console.Write(text);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Degree(int number, int degree)
{
    int numberDegree = 1;
    for(int i = 0; i < degree; i++ )
    {
        numberDegree *= number;
    }
    return numberDegree;
}

 bool DegreeExamination(int degree)
 {
    if (degree < 0)
    {
        Console.WriteLine("Введенное значение не должно быть меньше нуля");
        return false;
    }
    return true;
 }

int number = Promt("ВВедите основание ");
int degree = Promt("Введите степень ");

if (DegreeExamination(degree))
{
    Console.WriteLine($"Число {number} в степени {degree} равно { Degree (number, degree)}");
}

