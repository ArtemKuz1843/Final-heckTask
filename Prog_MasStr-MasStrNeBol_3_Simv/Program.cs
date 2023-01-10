// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.

string[] Counting = new string[] { "Турба", "Урба", "Сентебряки", "Эус", "Деус", "Раснодеус", "Бац" };

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
Console.WriteLine();

string[] ResizeStringsArr(string[] arr, int limit) //данный метод вычислит размер будущего массива строк, создаст его, заполнит и вернёт.
{
    int ResizeArrLength = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        string Str = arr[i];
        if (Str.Length <= limit) ResizeArrLength++;
    }

    string[] ResizeArr = new string[ResizeArrLength];
    int IndexResize = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        string Str = arr[i];
        if (Str.Length <= limit)
        {
            ResizeArr[IndexResize] = Str;
            IndexResize++;
        }
    }
    return ResizeArr;
}

Console.WriteLine("Преобразованный массив строк:");
string[] ResultArr = ResizeStringsArr(Counting, 3);
PrintArray(ResultArr);