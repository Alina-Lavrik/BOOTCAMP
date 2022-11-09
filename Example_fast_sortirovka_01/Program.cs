/* Быстрая сортировка по возрастанию
1. Получение массива array = [1, 0, -6, 2, 5, 3, 2]
2. array[6] == pivot (опортный элемент), все эл меньше опорного должны быть слева, а больше справа
3. Вызвать шаги 1-2 для подмассива слева от pivot и справа от pivot
*/

int[] arr = { 0, -5, 2, 3, 5, 9, -1, -7 };
QuickSort(arr, 0, arr.Length - 1);      // кол-во элементов -1 получим длинну массива 7
Console.Write($"Отсортированный массив {string.Join(", ", arr)}");

static void QuickSort(int[] inputArray, int minIndex, int maxIndex)   // Метод QuickSort возвращает массив, далее мин индекс от которого будем сортировать и 
{                                                                     // и макс индекс до которого будем сортировать
    if (minIndex >= maxIndex) return;
    int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
    QuickSort(inputArray, minIndex, pivot - 1);    // сортировка левой части, pivot - 1 т.к. pivot не включаем
    QuickSort(inputArray, pivot + 1, maxIndex);
    return;                                         // останавливаем рекурсию и ничего не возвращаем ткт метод void
}
static int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
{
    int pivotIndex = minIndex - 1;
    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (inputArray[i] < inputArray[maxIndex])
        {
            pivotIndex++;
            Swap(inputArray, i, pivotIndex);
        }
    }
    pivotIndex++;
    Swap(inputArray, pivotIndex, maxIndex);
    return pivotIndex;
}
static void Swap(int[] inputArray, int leftValue, int rightValue)   // void метод, функция Swap меняет мествми число кот. слева на число кот. справа
{
    int temp = inputArray[leftValue];
    inputArray[leftValue] = inputArray[rightValue];
    inputArray[rightValue] = temp;
}
