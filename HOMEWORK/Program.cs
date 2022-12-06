/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

// Функция получения числа с консоли
// int GetNumber(string messege)
// {
//     int result = 0;
//     bool isCorrect = false;

//     while (!isCorrect)
//     {
//         Console.WriteLine(messege);

//         if (int.TryParse(Console.ReadLine(), out result) && result > 9999 && result < 100000)
//         {
//             isCorrect = true;
//         }
//         else
//         {
//             Console.WriteLine("Вы ввели не пятизначное число. Введите корректно.");
//         }
//     }

//     return result;
// }

// int number = GetNumber("Введите пятизначное число:");
// int firstNumbr = number / 10;
// int secondNumbr = (number / 1000) % 10;

// if (number / 10000 == number % 10 && firstNumbr % 10 == secondNumbr)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }

// ...................................................................................................................


/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

// int GetNumber(string messege)
// {
//     int result = 0;
//     bool isCorrect = false;

//     while (!isCorrect)
//     {
//         Console.WriteLine(messege);

//         if (int.TryParse(Console.ReadLine(), out result))
//         {
//             isCorrect = true;
//         }
//         else
//         {
//             Console.WriteLine("Вы ввели не число или ноль. Введите корректно.");
//         }
//     }

//     return result;
// }

// int x1 = GetNumber("Введите x1:");
// int x2 = GetNumber("Введите x2:");
// int y1 = GetNumber("Введите y1:");
// int y2 = GetNumber("Введите y2:");
// int z1 = GetNumber("Введите x3:");
// int z2 = GetNumber("Введите y3:");

// double summ1 = Math.Pow((x2 - x1), 2);
// double summ2 = Math.Pow((y2 - y1), 2);
// double summ3 = Math.Pow((z2 - z1), 2);

// double result = Math.Sqrt(summ1 + summ2 + summ3);

// Console.WriteLine(result);

// ...........................................................................................................
/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

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
    Console.Write($"{Math.Pow(i, 3)} ");
}
