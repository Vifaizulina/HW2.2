// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
//23432 -> да

Console.Clear();

Console.Write ("Введите пятизначное число:");
int n = Convert.ToInt32(Console.ReadLine());
   if (n / 1000 == (n % 10) * 10 + (n % 100) / 10) // перевернутое число
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO"); 

    
