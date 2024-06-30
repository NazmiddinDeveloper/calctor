// calculator programm
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
