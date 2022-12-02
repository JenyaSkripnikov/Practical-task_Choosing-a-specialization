/*
Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

int GetElements(string message) 
{
    int digit;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int elementsCount) && elementsCount > 0)
        {
            digit = elementsCount;
            break;
        }
        else
        {
            Console.WriteLine($"{elementsCount} - Введены не корректные данные. Повторите ввод \n");
        }
    }
    return digit;
} 

void PrintArrayFirstIntroduced(string[] arrayFirstIntroduced)
{
    for (int i = 0; i < arrayFirstIntroduced.Length; i++)
    {
        Console.Write($"\nВведите элемент массива под индексом {i}: \t");
        arrayFirstIntroduced[i] = Console.ReadLine();
    }

Console.WriteLine();

    for (int j = 0; j < arrayFirstIntroduced.Length; j++)
    {
        Console.Write($"[{arrayFirstIntroduced[j]}] ");    
    }
}

void PrintArraySecond(string[] arrayFirstIntroduced)
{
    for (int i = 0; i < arrayFirstIntroduced.Count(); i++)
    {
        if(arrayFirstIntroduced[i].Length < 4)
        Console.Write($"[{arrayFirstIntroduced[i]}] ");;
    }
}

int elementsCount = GetElements("Введите количество элементов массива:\t");
string[] arrayFirstIntroduced = new string[elementsCount];
PrintArrayFirstIntroduced(arrayFirstIntroduced);
Console.WriteLine();
Console.WriteLine($"Элементы введенного массива, длина которых меньше, либо равна трём символам, следующие:");
PrintArraySecond(arrayFirstIntroduced);
Console.WriteLine();