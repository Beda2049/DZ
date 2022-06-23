// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int numberA;
int numberB;
int numberC;

Console.WriteLine("Уважаемый, введите пожалуйста число ");
numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("А можете ввести ещё одно число? ");
numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("И последнее число) ");
numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;
if (numberB > max)
{ 
     max = numberB;
}
if (numberC > max)
{
    max = numberC;
}
Console.WriteLine("max =" + max);


