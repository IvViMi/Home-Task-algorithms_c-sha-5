/*
Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Clear();
Console.WriteLine("Определение количества чётных чисел в случайном массиве");
int[] array = new int[4];
for (int i = 0; i < array.Length; i++)
 {
     array[i] = new Random().Next(100, 1001);
     Console.Write($"{array[i]} ");
}

int countEvenNum = 0;
for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0) countEvenNum = countEvenNum + 1;

}
Console.WriteLine();
Console.Write($"В данном массиве количество чётных чисел: '{countEvenNum}'");