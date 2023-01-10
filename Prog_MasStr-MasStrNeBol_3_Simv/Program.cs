// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.

string[] Counting = new string[] { "Турба", "Урб", "Сентебряки", "Эус", "Деус", "Раснодеус", "Бац" };

void PrintArray(string[] arr)
{
    int count = arr.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{arr[position]} ");
        position++;
    }
}

Console.WriteLine("Задан массив строк: ");
PrintArray(Counting);

Console.WriteLine();

string[] ResizeStringsArr(string[] arr, int num)
{
    string[] ResizesArr = new string[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        string line = arr[i];
        if (line.Length <= num)
        {
            ResizesArr[i] = line;
        }
        else ResizesArr[i] = string.Empty;
    }
    return ResizesArr;
}

Console.WriteLine();

Console.WriteLine("Преобразованный массив строк:");
string[] result = ResizeStringsArr(Counting, 3);
PrintArray(result);