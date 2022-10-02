/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
int Exp(int numA, int numB){
  int result = 1;
  for(int i=1; i <= numB; i++){
    result = result * numA;
  }
    return result;
}
int exponentiation = Exp(numA, numB);
Console.WriteLine("Число {0} в степени {1} равана {2}", numA, numB, exponentiation);

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

int number = ReadInt("Введи число: ");
int len = NumberLen(number);
SumNumbers(number, len);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int NumberLen(int a){
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}
void SumNumbers(int n, int len){
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine("Сумма введеных чисел = " + sum);
}


Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

int lenArray = ReadInt("Введи длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(0,99);
    Console.Write(randomArray[i] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}