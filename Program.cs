﻿//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите число от 1 до 7: ");
int number =  int.Parse(Console.ReadLine()!);
if (number<=5)
{
    Console.WriteLine ("нет");
}
else
{
    Console.WriteLine ("да");
}