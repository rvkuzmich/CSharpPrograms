// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int randNum = rand.Next(100, 1000);
System.Console.WriteLine(randNum);
int leftNum = randNum / 100;
int rightNum = randNum % 10;
int newNum = leftNum * 10 + rightNum;
System.Console.WriteLine(newNum);
// System.Console.WriteLine($"{leftNum}{rightNum}");
