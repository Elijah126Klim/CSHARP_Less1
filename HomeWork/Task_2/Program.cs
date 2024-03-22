// Задача № 2
// Программа: принимает на вход координаты Х и Y, 
// причем Х и Y не равны 0 и выдает номер координатной четверти плоскости, в которой эта точка.

int x;
int y;

Console.WriteLine("Ввести х");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввести y");
y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("1-я четверть");
else if (x < 0 && y > 0) Console.WriteLine("2-я четверть");
else if (x < 0 && y < 0) Console.WriteLine("3-я четверть");
else if (x > 0 && y < 0) Console.WriteLine("4-я четверть");
else  Console.WriteLine("Ошибка!"); 

