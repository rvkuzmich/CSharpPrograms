// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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




//   кому  Все
// static int[] GenArray(int size, int leftRange, int rightRange)
//         {
//             int[] array = new int[size];
//             Random random = new Random();
//             for (int i = 0; i < size; i++)
//             {
//                 array[i] = random.Next(leftRange, rightRange + 1);
//             }
//             return array;
//         }

//         static void PrintArray(int[] array)
//         {
//             Console.WriteLine("[" + string.Join(", ", array) + "]");
//         }
// static int[] MultiplyArray(int[] array){
//             int[] result = new int[array.Length/2+array.Length%2];
//             for (int i = 0; i < array.Length/2; i++){
//                 result[i] = array[i]*array[array.Length-1-i];
//             }
//             if (array.Length%2 != 0){
//                 result[^1] = array[array.Length/2];
//             }
//             return result;
//         }

//         static void Main(string[] args)
//         {
//             int[] array = GenArray(9, -10, 10);
//             PrintArray(array);
//             int[] result = MultiplyArray(array);
//             PrintArray(result);
//         }