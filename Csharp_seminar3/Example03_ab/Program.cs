// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double GetDistance (int x1, int y1, int x2, int y2) {
double distance = Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(x2 - x1, 2));
return distance;
}

int GetNumber (string message) {
int userNumber;
while (true) {
Console.Write(message);

if (int.TryParse(Console.ReadLine(), out int number)) {
userNumber = number;
break;
}
else {
Console.WriteLine($"{number} не является числом, повторите ввод.");
}
}
return userNumber;
}

int x1Number = GetNumber("Введите координату X1 - ");
int y1Number = GetNumber("Введите координату Y1 - ");
int x2Number = GetNumber("Введите координату X2 - ");
int y2Number = GetNumber("Введите координату Y2 - ");

double myDistance = GetDistance(x1Number, y1Number, x2Number, y2Number);

Console.WriteLine($"Расстояние между точками ({x1Number}, {y1Number}) и ({x2Number}, {y2Number}) составляет {Math.Round(myDistance, 2)}.");
