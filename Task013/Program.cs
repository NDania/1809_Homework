// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n / 100 > 1)
{
    if(n < 1000)
    {    
        Console.WriteLine(n % 10);
    }
    else
    if(n >= 1000 && n < 10000)
    {
        int n1 = n / 10;
        int n2 = n1 % 10;
        Console.WriteLine(n2); 
    }
    else
    if(n >= 10000 && n < 100000)
    {
        int n1 = n / 100;
        int n2 = n1 % 10;
         Console.WriteLine(n2);
    }    
}
else
    Console.WriteLine("Третьей цифры нет");