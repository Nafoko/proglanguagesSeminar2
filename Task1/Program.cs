﻿// // Напишите программу которая выводит случайное число из отрезка 
// // [10, 9] и показывает наибольшую цифру числа

// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 99);
Console.WriteLine($"Случайное число из отрезка [10, 99] -> {number}");

int firstDigit = number / 10; 
int secondDigit = number % 10;

if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"наибольшая цифра числа -> {maxDigit}");
