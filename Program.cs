Task10();

Console.ReadKey();
Task13();

Console.ReadKey();
Task15();


void Task10()
{
    Console.WriteLine("\nЗадача 10: Напишите программу, которая принимает на вход трёхзначное число " +
                    "и на выходе показывает вторую цифру этого числа.\n456 -> 5\n782 -> 8\n918 -> 1");

    Console.Write("Введите положительное трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int decades = number / 10 % 10;

    if (number > 99 && number < 1000) Console.WriteLine($"Вторая цифра числа {number} -> {decades}");
    else Console.WriteLine($"Введено неверное число");
}

void Task13()
{
    Console.WriteLine("\nЗадача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, " +
                    "что третьей цифры нет.\n645 -> 5\n78 -> третьей цифры нет\n32679 -> 6");

    Console.Write("Введите положительное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int number3 = number;

    if (number > 99)
    {
        while (number3 / 1000 > 0)
        {
            number3 = number3 / 10;
        }
        number3 = number3 % 10;
        Console.WriteLine($"Третья цифра числа {number} -> {number3}");
    }
    else Console.WriteLine($"В числе {number} третьей цифры нет");
}

void Task15()
{
    Console.WriteLine("\nЗадача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, " +
                   "и проверяет, является ли этот день выходным.\n6 -> да\n7 -> да\n1 -> нет");

    Console.Write("Введите номер дня недели: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number == 1) Console.WriteLine("Нет, понедельник - это не выходной, а будний день");
    else if (number == 2) Console.WriteLine("Нет, вторник - это не выходной, а будний день");
    else if (number == 3) Console.WriteLine("Нет, среда - это не выходной, а будний день");
    else if (number == 4) Console.WriteLine("Нет, четверг - это не выходной, а будний день");
    else if (number == 5) Console.WriteLine("Нет, пятница - это не выходной, а будний день");
    else if (number == 6) Console.WriteLine("Да, суббота - это выходной день");
    else if (number == 7) Console.WriteLine("Да, восресенье - это выходной день");
    else Console.WriteLine("Введен неверный день недели");
}
