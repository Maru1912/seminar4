// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

/*Console.WriteLine("Введите число А");
double num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
double num2 = Convert.ToInt32(Console.ReadLine());


    double result = Math.Pow(num1, num2);
    Console.WriteLine(result);*/




Console.WriteLine("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for (int i = 1; i < b; i++)
{
step = step * a;
}
Console.WriteLine("A в степени B = " + step);







//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.





 Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
 int sum = 0;



while (a > 0)
{
    int num = a % 10;
    a = a / 10;
    sum = sum + num;

}
Console.WriteLine("Сумма всех чисел равна: " + sum);



//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.




int[] array = new int[8];




for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 9);
    Convert.ToString(" " + array[i] + " ");
}

string result = string.Join("", array);
Console.Write($"[" + result + "]");*/
