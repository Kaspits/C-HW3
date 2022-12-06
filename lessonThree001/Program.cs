// Написать программу, которая принимает на вход координатные точки не равные 0,
// и выдает номер четверти полоски, в которой находится точка


// Функция получения числа с консоли
int GetNumber(string messege)
{
    int result = 0;
    bool isCorrect = false;

    while (!isCorrect)
    {
        Console.WriteLine(messege);

        if (int.TryParse(Console.ReadLine(), out result) && result != 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Вы ввели не число или ноль. Введите корректно.");
        }
    }

    return result;
}

// Получение четверти, в которой находится точка с координатами
int GetQuarter(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else
        return 4;
}

int x = GetNumber("Введите координату Х:");
int y = GetNumber("Введите координату Y:");

int quarter = GetQuarter(x, y);

Console.WriteLine($"точка с координатами({x}, {y} лежит в {quarter} четверти)");
