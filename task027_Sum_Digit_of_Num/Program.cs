﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)//исправление конвертации строки в int
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine()!;
    int result = Convert.ToInt32(readInput);
    return result;
}

int DigitSum(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10; //result = result + (number % 10);
        number /=10; // number = number / 10;
    }
    return result;
}

int num = Prompt("Input number: ");
Console.WriteLine();

Console.WriteLine($"Number={num} DigitSum = {DigitSum(num)}");
