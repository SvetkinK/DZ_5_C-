// Заполнить одномерный массив случайными числами. Найти сумму элементов, стоящих на нечетных позициях.
// [3,7,23,12]->19  [-4,-6,89,6]->0
void FillArray(int[] arr)
{
  for(int i=0; i<arr.Length; i++)
  arr[i] = new Random().Next(-10, 100);
}

void PrintArray(int[] print)
{
  foreach(int i in print)
  Console.Write($"{i},");
  Console.WriteLine();
}

int SumNum(int[] ar)
{
  int sum = 0;
  for(int i = 1; i<ar.Length; i = i+2)
  sum = sum + ar[i];
  return sum;
}

int [] array = new int[5];
FillArray(array);
PrintArray(array);
Console.WriteLine(SumNum(array));