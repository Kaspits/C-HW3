// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Функция получения числа с консоли
int GetNumber(string messege)
{
    int result = 0;
    bool isCorrect = false;

    while (!isCorrect)
    {
        Console.WriteLine(messege);

        if (int.TryParse(Console.ReadLine(), out result))
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

int x1 = GetNumber("Введите x1:");
int x2 = GetNumber("Введите x2:");
int y1 = GetNumber("Введите y1:");
int y2 = GetNumber("Введите y2:");

double summ1 = Math.Pow((x2 - x1), 2);
double summ2 = Math.Pow((y2 - y1), 2);

double result = Math.Sqrt(summ1 + summ2);

Console.WriteLine(result);
