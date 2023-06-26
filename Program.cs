// Задача №1. Напишите программу, которая на вход принимает два числа и проверят, является ли первое число квадратом второго.
// a = 25, b =5 -> да
// a = 2, b =10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> среда
// 5 -> пятница


Console.WriteLine("Введите целое число A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число B");
int numB = Convert.ToInt32(Console.ReadLine());
int resultB = numB * numB;

if(numA == resultB)

    System.Console.WriteLine("Число А является квадратом числа В");

else 
    System.Console.WriteLine("Число А не является квадратом числа В");


// Задача №1. Напишите программу, которая на вход принимает два числа и проверят, является ли первое число квадратом второго.
// a = 25, b =5 -> да
// a = 2, b =10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> среда
// 5 -> пятница


Console.WriteLine("Введите целое число A");
int num = Convert.ToInt32(Console.ReadLine());

if(num==1)
    System.Console.WriteLine("Понедельник");
else if(num==2)
    System.Console.WriteLine("Вторник");
else if(num==3)
    System.Console.WriteLine("Среда");
else if(num==4)
    System.Console.WriteLine("Четверг");
else if(num==5)
    System.Console.WriteLine("Пятница");
else if(num==6)
    System.Console.WriteLine("Суббота");
else if(num==7)
    System.Console.WriteLine("Воскресенье");
else 
    System.Console.WriteLine("Вы ввели неправильное число");



Console.WriteLine("Введите целое число A");
int nu = Convert.ToInt32(Console.ReadLine());
switch(nu)
{
    case 1:
         System.Console.WriteLine("Понедельник");
        break;
    case 2:
        System.Console.WriteLine("Вторник");
        break;
    case 3:
        System.Console.WriteLine("Среда");
        break;
    case 4:
        System.Console.WriteLine("Четверг");
        break;
    case 5:
        System.Console.WriteLine("Пятница");
        break;
    case 6:
        System.Console.WriteLine("Суббота");
        break;
    case 7:
        System.Console.WriteLine("Воскресенье");
        break;
    default:
    System.Console.WriteLine("Вы ввели неправильное число");
        break;
}


// Задача №5. Напишите программу ,которая на вход принимает одно число N, а на выходе показывает
// все целые числа в промежутке от -N до N.
// 4->"-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2->"-2, -1, 0. 1, 2"


Console.WriteLine("Введите целое число N");
int numN = Convert.ToInt32(Console.ReadLine());
int count=-numN;

while (count<=num)
{   System.Console.WriteLine(count+", ");
    count++;
    }

    Console.WriteLine("Введите целое число N");
int numN = Convert.ToInt32(Console.ReadLine());
int count=-numN;

while (count<=num)
{   System.Console.WriteLine(count+", ");
    count++;
    }