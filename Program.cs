// массив с уорядоченными по убыванию строками




/*
int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue);
        }
    return newArray;
}
void Show2DArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
}
int[,] SortLine(int [,] array)
{   
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }    
        }
    }
    return array;
}
Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray(m,n,min,max);
Show2DArray(myArray);
myArray = SortLine(myArray);
Console.WriteLine();
Show2DArray(myArray);


*/


// масив с нахождением сторки с наименьшей суммой элементов

/*

int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue);
        }
    return newArray;
}
void Show2DArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
}
void MinSumRow(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        minRow += array[0, i];
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            sumRow += array[j, k];
            {
                if (sumRow < minRow)
                {
                    minRow = sumRow;
                    minSumRow = i;
                }
                sumRow = 0;
            }
            
                       
        }
        
    }
    Console.Write($"Наименьшая сумма элементов в  {minSumRow + 1}-й строке");
    
}
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray(m,n,min,max);
Show2DArray(myArray);
MinSumRow(myArray);


*/

// сознание двух матриц и перемножение их

int[,] ArrayForMatrix(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue);
        }
    return newArray;
}

void Show2DArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

int[,] FinishMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      array[i,j] = sum;
    }
  }
  return array;
}

Console.WriteLine("Введите число строк первой и второй матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов первой и второй матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = ArrayForMatrix(m,n,min,max);
Console.WriteLine($"Первая матрица: ");
Show2DArray(firstMatrix);

int[,] secondMatrix = ArrayForMatrix(m,n,min,max);
Console.WriteLine($"Вторая матрица: ");
Show2DArray(secondMatrix);

int[,] myArray = ArrayForMatrix(m,n,min,max);
int[,] endMatrix = FinishMatrix(firstMatrix, secondMatrix, myArray);
Console.WriteLine($"Произведение первой и второй матриц:");
Show2DArray(endMatrix);

