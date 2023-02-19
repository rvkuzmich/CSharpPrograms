Random rand = new Random();
int randNumber = rand.Next(10, 100);

System.Console.WriteLine(randNumber);
int leftNumber = randNumber / 10;
int rightNumber = randNumber % 10;

if (leftNumber > rightNumber)
{
    System.Console.WriteLine($"{leftNumber} > {rightNumber}");
}
else if (rightNumber > leftNumber)
{
    System.Console.WriteLine($"{rightNumber} > {leftNumber}");
}
else
{
    System.Console.WriteLine("Числа равны");
}