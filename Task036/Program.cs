/*
Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.Clear();
Console.WriteLine("Определение суммы чисел на нечётных позициях в случайном массиве");
int[] array = new int[4!];
for (int i = 0; i < array.Length; i++)
 {
     array[i] = new Random().Next(0, 10);
     Console.Write($"{array[i]} ");
}

int count = 0;
for (int j = 0; j < array.Length; j++)
{
    if (j % 2 == 1) count = count + array[j];

}
Console.WriteLine();
Console.Write($"В данном массиве сумма чисел, которые на нечётных позициях: '{count}'");