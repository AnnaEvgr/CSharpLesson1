/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

System.Console.WriteLine("Введите первое число");
String? number = Console.ReadLine();
int a = Convert.ToInt32(number);
System.Console.WriteLine("Введите второе число");
String? number2 = Console.ReadLine();
int b = Convert.ToInt32(number2);
System.Console.WriteLine("Введите третье число");
String? number3 = Console.ReadLine();
int c = Convert.ToInt32(number3);
if ((a > b) && (a > c))
{
    System.Console.WriteLine($"Max {a}");
}
else
if (b > c)
{
    System.Console.WriteLine($"Max {b}");
}
else System.Console.WriteLine($"Max {c}");