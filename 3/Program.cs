﻿/* Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7

6 -> да
7 -> да
1 -> нет
*/

System.Console.WriteLine("Введите номер дня недели: ");
 int num = int.Parse(Console.ReadLine()); 
if (num >= 1 && num <= 5) 
{ 
    Console.Write(" Увы, это не выходной"); 
} 
 
else if (num >= 6 && num <= 7) 
{ 
    Console.Write(" Ура, выходной"); 
} 
else Console.Write("Внимание! Такого дня не существует"); 