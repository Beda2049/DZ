// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int numberA;

Console.WriteLine("Уважаемый, введите пожалуйста число ");
numberA = int.Parse(Console.ReadLine());

if(numberA % 2 == 0)
{
    Console.Write("Введенное число является четным");
    Console.Read();
}
else
{
    Console.Write("Введенное число нечетное");
    Console.Read();
}


