// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1); // [-9, 10) > -9 до 9
    }

    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void FindElement(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            System.Console.WriteLine("Yes");
            return;
        }
    }
    System.Console.WriteLine("No");
}

int[] arr = GenerateArray(20, -20, 20);
PrintArray(arr);
System.Console.WriteLine("Введите искомое число: ");
int num = Convert.ToInt32(Console.ReadLine());
FindElement(arr, num);

// void FindElement(int[] array, int number)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             System.Console.WriteLine("Yep");
//             return;
//         }

//     }
//     System.Console.WriteLine("Nope");
// }
// const int SIZE = 20;
// const int LEFT_RANGE = -20;
// const int RIGHT_RANGE = 20;

// var myArray = GenerateArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
// PrintArray(myArray);

// System.Console.WriteLine("введите искомое число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// FindElement(myArray, number);


