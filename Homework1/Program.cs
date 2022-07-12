/* Task 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2)
{
    Console.WriteLine("Min number: " + num1);
    Console.WriteLine("Max number: " + num2);
}  
else
{
    Console.WriteLine("Min number: " + num2);
    Console.WriteLine("Max number: " + num1);
}

// Task 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max;
if (num1 > num2)
    max = num1;
else
    max = num2;
if (num3 > max)
    max = num3;
Console.WriteLine("Max number: " + max);

// Task 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if ((num % 2) == 0)
    Console.WriteLine("Четное");
else
    Console.WriteLine("Нечетное");

// Task 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;

while (current <= num)
{
    if (current % 2 == 0)
        Console.Write(current + " ");
    current ++;
}
*/

