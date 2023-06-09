// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  0, 7, 8, -2, -2 -> 2
//  -1, -7, 567, 89, 223-> 3

//пользовательский ввод количества элементов в массиве и элементов массива
int[] GetNumberArray()
{
    Console.WriteLine("Введите количество цифр, которые будут вводиться: ");
    int numCount = Convert.ToInt32(Console.ReadLine());
    int[] numArray = new int[numCount];
    for (int i = 0; i < numCount; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        numArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numArray;
}

//вывод массива на экран (универсальный)
void PrintArray(int[] arr, string sep = ",")
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else
        {
            Console.Write($"{arr[i]}");
        }
    }
    Console.Write("]");
}

int CountPositiveArray(int[] arr)
{
    int countPositive = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)  countPositive = countPositive + 1;
    }
    return countPositive;
}

int[] array = GetNumberArray();
int countPositiveArray = CountPositiveArray(array);
PrintArray(array, ";");
Console.Write($"-> {countPositiveArray}");