// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите день недели в цифровом выражении: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1 || n > 7)
    Console.WriteLine("Вы ошиблись при вводе, повторите попытку");
else
    if( n == 6 || n == 7)
         Console.WriteLine("День является выходным");
    else
        Console.WriteLine("День выходным не является");     