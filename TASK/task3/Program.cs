/* 
Задача 29: Напишите метод, 
который задаёт массив из N 
элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
void WriteArray(int[] arr, int a, int b) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
}


String PrintArray(int[] arr)
{
    string output = String.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        output += arr[i] + " ";
    }
    return output;
}

int[] array = new int[10];
WriteArray(array, 1, 100);
Console.WriteLine(PrintArray(array));
