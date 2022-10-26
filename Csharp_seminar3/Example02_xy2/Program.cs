//Задача 18: Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

int GetConsole(string msg)
{
int result;

while (true)
{
Console.Write(msg);

if (int.TryParse(Console.ReadLine(), out int number) && number > 0 && number < 5)
{
result = number;
break;
}
else
{
Console.WriteLine("Ввели некорректное число! Повторите ввод. \n");
}
}

return result;
}

void GetQuater(int x)
{
switch (x)
{
case 1:
Console.WriteLine("x > 0; y > 0");
break;
case 2:
Console.WriteLine("x < 0; y > 0");
break;
case 3:
Console.WriteLine("x < 0; y < 0");
break;
case 4:
Console.WriteLine("x > 0; y < 0");
break;
default:
Console.WriteLine("Выход из диапозона");
break;
}
}

int x = GetConsole("Введите четверть от 1 до 4: ");
GetQuater(x);