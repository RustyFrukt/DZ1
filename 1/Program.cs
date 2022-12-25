// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков
System.Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
if (number.Length < 3)
{
    System.Console.WriteLine("Внимание! Указанное число содержит менее 3х знаков");
}
else
{
    System.Console.WriteLine(number[1]);
}