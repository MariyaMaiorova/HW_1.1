//Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
Console.Write("ВВедите первое число > ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите второе число > ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
   { Console.WriteLine($"{firstNumber} максимальное число, {secondNumber} минимальное число"); }
else 
   { Console.WriteLine($"{firstNumber} минимальное число, {secondNumber} максимальное число"); }
