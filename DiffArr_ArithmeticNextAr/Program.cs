// Задать массив случайных чисел.
//Найти max элемент и его индекс, min элемент и его индекс, среднеарифметическое всех элементов.
//Сохранить инфо в отдельный массив и вывести на экран с пояснениями.
//Найти медианное значение первоначального массива.
void FillArray(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().Next(1, 1000);
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

void ArithmeticArray(int[] ar)
{
  int max = 0;
  int min = 1000;
  int j = 0;
  int g = 0;
  int arithMean = 0;
  int median = 0;
  for (int i = 0; i < ar.Length; i++)
  {
    if (ar[i] > max)
    {
      max = ar[i];
      j = i;
    }
    if (ar[i] < min)
    {
      min = ar[i];
      g = i;
    }
    arithMean = arithMean + ar[i];
  }
  for (int i = 0; i < ar.Length - 1; i++)
  {
    int minPos = i;
    for (int k = i + 1; k < ar.Length; k++)
    {
      if (ar[k] < ar[minPos]) minPos = k;
    }

    int temp = ar[i];
    ar[i] = ar[minPos];
    ar[minPos] = temp;
    if (ar.Length % 2 != 0) median = ar[ar.Length / 2];
    else median = (ar[ar.Length / 2] + ar[ar.Length / 2 - 1]) / 2;
  }
  arithMean = arithMean / ar.Length;
  int[] next = { min, max, arithMean, median };
  Console.WriteLine($"Минимальное значение {min} с индексом {g}");
  Console.WriteLine($"Максимальное значение {max} с индексом {j}");
  Console.WriteLine($"среднеарифметическое значение {arithMean}");
  Console.WriteLine($"медиана = {median}");
  foreach (int i in next)
  {
    Console.Write($"{i},");
  }
  Console.WriteLine();
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);
ArithmeticArray(array);

