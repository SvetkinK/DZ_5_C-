// Задать массив вещественных чисел. Найти разницу между max и min элементов массива.
//[3 7 22 2 78]->76
void FillArray(double[] arr)
{
  for (int i = 0; i < arr.Length; i++)
    arr[i] = new Random().NextDouble() * 100;
}

void PrintArray(double[] ar)
{
  foreach (int i in ar)
    Console.Write($"{i} ");
  Console.WriteLine();
}

void Diff(double[] arr)
{
  double diff = 0;
  double max = 0;
  double min = 100;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > max)
      max = arr[i];
    if (arr[i] < min)
      min = arr[i];
  }
  // diff = Math.Round(max - min);
  diff = Convert.ToInt32(max - min);
  Console.WriteLine($"{diff}");
  //return diff;
}


double[] array = new double[5];
FillArray(array);
PrintArray(array);
Diff(array);