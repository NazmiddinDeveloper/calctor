﻿// calculator programm 
int number1;
int number2;
string userName;
Console.Write("Hello user please type your name : ");
userName = Console.ReadLine();
Console.Write($"{userName} please enter first number : ");
number1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"{userName} please enter second number : ");
number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{number1} + {number2} = {number1+number2}");
Console.WriteLine($"{number1} - {number2} = {number1-number2}");
Console.WriteLine($"{number1} * {number2} = {number1*number2}");
Console.WriteLine($"{number1} / {number2} = {number1/number2}");

Console.WriteLine($"{number1} % {number2} = {number1%number2}");

System.Console.WriteLine($"variable number1 is greater than variable number2 {number1 > number2}");
System.Console.WriteLine($"variable number1 is greater or equal than variable number2 {number1 >= number2}");
System.Console.WriteLine($"variable number1 is less than variable number2 {number1 < number2}");
System.Console.WriteLine($"variable number1 is less or equal than variable number2 {number1 <= number2}");
System.Console.WriteLine($"variable number1 is equal variable number2 {number1 == number2}");
System.Console.WriteLine($"variable number1 is not equal variable number2 {number1 != number2}");
