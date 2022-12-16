/* Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии. */

/* class Program
{
static void Main(string[] args)
    {
    Console.WriteLine("Введите натуральное число больше 1:");
    int number = int.Parse(Console.ReadLine());
            
    void NumberCounter(int number)
        {
        if (number < 0) Console.Write($"{number} не натуральное число");
        if (number == 0) return;
        Console.Write("{0,4}", number);
        NumberCounter(number - 1);
        }
            
    NumberCounter(number);            
    }
} */


/*
Задача 66:
Задайте значения M и N. Напишите программу, которая найдёт сумму
 натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/* int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

int NumbersSum(int count, int number, int total)
{
    if(count > number) return total;
    else
    {
        total += count;
        return NumbersSum(count + 1, number, total);
    }
    
}

int userNumberM = GetNumber("Введите число M: ");
int userNumberN = GetNumber("Введите число N: ");
Console.WriteLine();
int total = NumbersSum(count: userNumberM, number: userNumberN, total: 0);
Console.Write($"Сумма натуральных элементов в промежутке от {userNumberM} до {userNumberN} = {total}"); */


/*
Задача 68:
Напишите программу 
вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int GetNumber(string msg)
{
    Console.Write(msg);
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out var userNumber))
        if(userNumber >= 0)
        return userNumber;
        else
        Console.WriteLine("Введенное значение не удовлетворяет требованиям задачи\n");
    }
}

static int S(int n, int m)
{
  if ((n == 1) && (m == 1))
    return 1;
  else
    if (n > 1)
      return S(n - 1, m) + m;
    else
      return S(n, m - 1) + 1;
}

int userNumberM = GetNumber("Введите число M: ");
int userNumberN = GetNumber("Введите число N: ");
Console.WriteLine();
int result = S(m: userNumberM, n: userNumberN);
Console.Write($"Функция Аккермана для {userNumberM} и {userNumberN} = {result}");