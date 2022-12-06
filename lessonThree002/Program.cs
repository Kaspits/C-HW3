// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// Функция получения номера четверти.
int GetNumber(string messege)
{
    int result = 0;
    bool isCorrect = false;

    while (!isCorrect)
    {
        Console.WriteLine(messege);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0 && result <= 4)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Введите корректноe число.");
        }
    }

    return result;
}

// Получение возможных велечин четверти
string GetQuarter(int number)
{
    if (number == 1)
        return "Возможный диапазон от 0 до бесконечности, Y: (от 0 до бесконечности)";
    else if (number == 2)
        return "Возможный диапазон от 2 до бесконечности, Y: (от 0 до бесконечности)";
    else if (number == 3)
        return "Возможный диапазон от 3 до бесконечности, Y: (от 0 до бесконечности)";
    else
        return "Возможный диапазон Х: (от 4 до бесконечности), Y: (от 0 до бесконечности)";
}

int number = GetNumber("Введите номер четверти (1-4):");

string quarter = GetQuarter(number);

Console.WriteLine($"Для четверти {number}: {quarter})");
