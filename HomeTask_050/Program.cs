void InputArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      array[i, j] = new Random().Next(1, 101);
  }
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write($"{array[i, j]} \t");
    Console.WriteLine();
  }
}
double[] CalculateAvereges(int[,] array);
{
  double[] averages = new double[array.GetLength(1)];
  for (int j = 0; j < array.GetLength(1); j++)
  {
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
       sum += array[i, j];
    }
    averages[j] = (double)sum / array.GetLength(0);
  }
  return result;
}
 

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
double[,] array = new double[size[0], size[1]];
InputArray(array);
Console.WriteLine("Начальный массив: ");
PrintArray(array);
Console.WriteLine("Средние арифметические: ");
for (int j = 0; j < averages.Length; j++)
{
  Console.WriteLine($"Столбец {j + 1}: {averages[j]}");
}
CalculateAvereges(array);