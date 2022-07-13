/*
Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива. 
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
*/
Console.Clear();
Console.WriteLine("Определение разницы вещетсвенных чисел в случайном массиве между максимальным и минимальным значениями");
double[] array = new double[5];
for (int i = 0; i < array.Length; i++)
 {
     array[i] = new Random().NextDouble()*100;
     Console.Write($"{array[i]} ");
}
double max = array[0];
double min = array[0];

for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max) max = array[j];
    if (array[j] < min) min = array[j];
}
Console.WriteLine();
Console.Write($"Разница между максимальным и минимальным значениеми - '{max - min}'");