﻿// на вход принимает число
//  и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.WriteLine("Введите число a =");
int a = Convert.ToInt32(Console.ReadLine());
if ( ( a % 2 ) != 0)
{
    Console.WriteLine("Число четное?  НЕТ!");
}
else Console.WriteLine("Число четное?  ДА!");

    

