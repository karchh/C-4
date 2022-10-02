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

ниже через методы попробовал:*/

int numA = ReadInt("Введите число А: ");
int numB = ReadInt("Введите число B: ");
ToDegree(numA, numB);

void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine("Число {0} в степени {1} равана {2}", numA, numB, result);
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
