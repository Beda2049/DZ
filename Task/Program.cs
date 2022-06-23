//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int numberA;
int numberB;
int min;
int max;

Console.WriteLine("Уважаемый, введите пожалуйста число ");
numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("А можете ввести ещё одно число? ");
numberB = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB)
{
    max = numberA;
    min = numberB;
}
else
{
    min = numberA;
    max = numberB;

}

Console.WriteLine("min =" + min);
Console.WriteLine("max =" + max);


