﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// System.Console.WriteLine(" введите число А...");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(" введите число B...");
// int b = Convert.ToInt32(Console.ReadLine());
// int degree = a;
// for( int i = 1; i < b; i++){
//     degree = degree*a;
// }
// System.Console.WriteLine("А в степени В равно:" + degree);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumber(int numberN){

int counter = Convert.ToString(numberN).Length;
int advance = 0;
int result = 0;

for (int i = 0; i < counter; i++){
advance = numberN - numberN % 10;
result = result + (numberN - advance);
numberN = numberN / 10;
}
return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);

