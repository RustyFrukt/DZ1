// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000

System.Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
if (number.Length < 3)
{
    System.Console.WriteLine("Внимание! Указанное число содержит менее 3х знаков");
}
else
{
    System.Console.WriteLine(number[2]);
}