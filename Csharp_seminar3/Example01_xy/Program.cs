/*Напишите программу, которая принимает на вход координаты точки (X и Y),
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

int GetСoordinate(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out int number) && number != 0)
        {
            result = number;
            break;
        }
    else
        {
            Console.WriteLine("Ввели не число или число равное нулю. Повторите ввод \n");
        }
    }

    return result;
}

int GetQuarter(int x, int y)
{
if(x == 0 || y == 0)
return -100;

if(x > 0 && y > 0)
return 1;
else if(x < 0 && y >0)
return 2;
else if(x < 0 && y < 0)
return 3;
else
return 4;
}


int x = GetСoordinate("Введите координату х:");
int y = GetСoordinate("Введите координату y:");
int quarter = GetQuarter(x, y);

Console.WriteLine($"Точка с координатами ({x}, {y}) находится в {quarter} четвери.");