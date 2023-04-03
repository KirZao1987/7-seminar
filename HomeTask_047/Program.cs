void InputNumbersArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      array[i, j] = Math.Round(new Random().NextDouble() * 10, 2);
  }
}

void PrintArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write($"{array[i, j]} \t");
    Console.WriteLine();
  }
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
double[,] array = new double[size[0], size[1]];
InputNumbersArray(array);
Console.WriteLine("Начальный массив: ");
PrintArray(array);


