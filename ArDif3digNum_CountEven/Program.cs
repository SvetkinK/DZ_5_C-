// Массив заполнить случайными трехзначными числами
// Сколько чётных чисел в массиве? [345,897,568,234]->2

void FillArray(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().Next(100, 1000);
  }
}

void PrintArray(int[] arr)
{
  foreach (int i in arr)
  {
    Console.Write($"{i},");
  }
  Console.WriteLine();
}

int CountEven(int[] ev)
{
  int count = 0;
  foreach (int i in ev)
    if (i % 2 == 0)
      count++;
  return count;
}

int[] array = new int[5];
FillArray(array);
PrintArray(array);
Console.WriteLine(CountEven(array));

