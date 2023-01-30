// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите цифру от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

string[] arr = {"Понедельник",
                "Вторник",
                "Среда",
                "Четверг",
                "Пятница",
                "Суббота",
                "Воскресенье"};

if (number > 7 || number < 1)
{ System.Console.WriteLine("Нет такого дня недели."); }
else
{
    if (number == 6 || number == 7)
    {
        System.Console.WriteLine($"{arr[number - 1]} - Выходной!");
    }
    else
    {
        System.Console.WriteLine($"{arr[number - 1]} - Рабочий день(");
    }
}
