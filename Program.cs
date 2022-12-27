// Задача 1 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. 14212-> нет, 12821-> да, 23432-> да
/*System.Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine();
if (num.Length > 5 || num.Length < 5)
{
    System.Console.WriteLine("Ошибка! Число должно содержать не менее и не более пяти знаков");
}
else if (num[0] == num[4] && num[1] == num[3])
{
    System.Console.WriteLine($"Число {num} является палиндромом");
}
else
{
    System.Console.WriteLine($"Число {num} не является палиндромом");
}*/
// Задача 2 Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве. A (3,6,8); B (2,1,-7)-> 15.84,
//A (7,-5, 0); B (1,-1,9)-> 11.53
/*System.Console.Write("Введите координату x точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату y точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату z точки А: ");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату x точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату z точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double result = Math.Round(Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2)),2); 
System.Console.WriteLine($"Расстояние между двумя точками: {result}");*/