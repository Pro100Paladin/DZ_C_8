// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.Clear();
Console.WriteLine($"Заполните спирально массив 4 на 4.");

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($"{array[i,j]:d2} ");

      else Console.Write($"{array[i,j]:d2} ");
    }
    Console.WriteLine();
  }
}

//вариант преподователя
// Console.Write("Введите размерность массива, который будем заполнять: ");
// int n = int.Parse(Console.ReadLine()!);

// int[,] array = new int[n, n];
// int temp = 1;
// int i = 0;
// int j = 0;
// while (temp <= n * n)
// {
//     array[i,j] = temp;
//     if (i <= j + 1 && i + j < n - 1) 
//         ++j;
//     else if (i < j && i + j >= n - 1)
//         ++i;
//     else if (i >= j && i + j > n - 1)
//         --j;
//     else
//         --i;
//     ++temp;
// }
// for (int c = 0; c < array.GetLength(0); c++)
// {
//     for (int d = 0; d < array.GetLength(1); d++)
//     {
//         Console.Write( $"{array[c,d]:d3} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();