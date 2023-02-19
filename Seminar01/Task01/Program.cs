Console.WriteLine("Введите число:"); //Вывод в терминал приглашения пользователю ко вводу числа
int number = Convert.ToInt32(Console.ReadLine()); //Получение числа из терминала с конвертацией текста в число
int square = number * number;
//Console.WriteLine("Квадрат числа равен " + square);
Console.WriteLine($"Квадрат числа равен {square}. Еще какой-то текст");