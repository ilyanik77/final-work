// Напишите программу,которая из имеющегося массива строк формирует массив строк,
// длина которых меньше либо равна 3 символам.

Console.Write("Сколько элементов Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayStrings = new string[size];

int len = 3;
for (int i = 0; i < size; i++)
{
 Console.WriteLine($"Введите {i+1}-й элемент: ");
 string element = Console.ReadLine();
 if (element.Length <= len)
    {
        arrayStrings[i] = element;

    }
}
Console.WriteLine();
PrintArray(arrayStrings);


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}