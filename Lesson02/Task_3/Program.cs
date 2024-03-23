// Задача № 3
// Дано N гирь с разным весом, найти вес самой тяжелой гири. // Дано 100 гирь, найти вес самой тяжелой.

int n = 5;
int[] array = { 9, 4, 7, 3, 2 };
int i = 0;
int max = array[0];
while (i < n)
{
    if (array[i] > max)
    {
    max = array[i]; // текущий эл-т массива
    }
    i = i +1;
}
Console.WriteLine(max);

max = array[0];
for (int j = 0; j < n; j++)   // j = j + 1
{ 
    if (array[j] > max)
    {
    max = array[j]; // текущий эл-т массива
    }
}
Console.WriteLine(max);

max = array[0];
foreach (int e in array) // нет индекса
{
    if (e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);