// Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}
int N = EnterData("Введите пятизначное число N: ");
   if ((N /10) % 10 == (N / 1000) % 10)
     if (N % 10 == N / 10000)
  Console.WriteLine($"{N} -> да");
  else
  {
  Console.WriteLine($"{N} -> нет");
  }
