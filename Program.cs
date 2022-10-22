//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// int SecondDigit(int num)
// {
//     return (num / 10) % 10;
// }
// Console.Write("Input third-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = SecondDigit(number);
// Console.WriteLine($"The second digit of {number} is {result}.");

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
//сообщает, что третьей цифры нет.

// void ThirdDigit(int number,int len)
// {
//     int thirdDigit = number;
//     for(int i = len; i > 3; i--)
//     {
//         thirdDigit = thirdDigit / 10;
//     }
//     thirdDigit = thirdDigit % 10;
//     Console.WriteLine($"The third digit of {number} is {thirdDigit} ");    
// }

// Console.Write("Input a number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int length = number.ToString().Length;
// if(length > 2) ThirdDigit(number, length);
// else Console.WriteLine("Third digit not found.");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.

// bool WeekendDay (int day)
// {
//     if(day == 6 || day == 7) return true;
//     else return false;
// }

// Console.Write("Input the number of the day of the week: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num > 1 && num < 7) 
// {
//     if (WeekendDay(num)) Console.WriteLine("Yes!!!");
//     else Console.WriteLine("No((");
// }
// else Console.WriteLine("There is no day of the week with this number.");