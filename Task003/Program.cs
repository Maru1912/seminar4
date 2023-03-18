//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.


/*Console.WriteLine("Введите x 1 точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y 1 точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x 2 точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y 2 точки");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z 1 точки");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z 2 точки");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(DistancePount(x1, y1, x2, y2, z1, z2));




double DistancePount(int x1, int y1, int x2, int y2,int z1, int z2 )
{
    double result1 = (x2 - x1)*(x2 - x1);
    double result2 = (y2 - y1)*(y2 - y1);
    double result3 = (z2 - z1)*(z2 - z1);
    double result = Math.Sqrt(result1 + result2 + result3);
    return result;

}*/



//Напишите программу, которая принимает 
//на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

/*int num, r, sum = 0, palindrome;
Console.Write("Введите пятизначное число: ");
num = Convert.ToInt32(Console.ReadLine());




if (num > 9999 && num < 100000)
{
    for (palindrome = num; num != 0; num = num /10)
    {
    r = num % 10;
    sum = sum * 10 + r;   
    }
    if (palindrome == sum)
    Console.Write($"Число {palindrome} является палиндромом.");
else
Console.Write($"Число {palindrome} не является палиндромом.");
}
else 
Console.Write("Вы ввели неверное значение");*/





//Напишите программу, которая принимает 
//на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

/*Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());


for( int i = 1; i <= num; i ++)

Console.WriteLine($"{i * i * i} ");
Console.WriteLine(" ");*/


