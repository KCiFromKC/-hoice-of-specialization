// Напишите программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

Console.Clear();

Console.WriteLine("Введите желаемый размер массива:");
int arrayLenght = Convert.ToInt32(Console.ReadLine());

string[] array = new string[arrayLenght];

FillArray(array);
Console.WriteLine($"Получился следующий массив: {string.Join(", ",array)}");

string[] FillArray(string[] array)
{
    int j = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите значение {j} элемента массива:");
        array[i] = Console.ReadLine();
        if (array[i] == "") array[i] = " ";
        j++;
    }
    return array;
}