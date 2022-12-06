// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Функция получения числа с консоли
int GetNumber(string messege)
{
    int result = 0;
    bool isCorrect = false;

    while (!isCorrect)
    {
        Console.WriteLine(messege);

        if (int.TryParse(Console.ReadLine(), out result) && result >= 1)
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

int lin = GetNumber("Введите число:");

for (int i = 1; i <= lin; i++)
{
    Console.Write($"{Math.Pow(i, 2)} ");
}
