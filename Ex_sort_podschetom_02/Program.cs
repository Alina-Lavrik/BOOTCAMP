// Сортировка подсчетом 2

int[] array = {88, 0, 2, 4, 10, 20, 5, 6, 1, 2, 49};

int[] sortedArray = CountingSortExtended(array);

Console.WriteLine(string.Join(", ", sortedArray));

void CountingSort(int[] inputArray)
{
    int[] counters = new int[10];         

    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i]]++;
    }

    int index = 0;

    for (int i = 0; i < counters.Length; i++)   // обход кол-ва повторений в вспомогательном массиве
    {
        for (int j = 0; j < counters[i]; j++)  // цикл выполнится столько раз сколько у исходного числа повторений в массиве, 0 - 1 раз, 1 - 3 раза..
        {
            inputArray[index] = i;
            index++;
        }
    }
}

int[] CountingSortExtended(int[] inputArray)
{
    int max = inputArray.Max();    // получаем максимальный элемент
    int[] sortedArray = new int[inputArray.Length];  // новый массив

    int[] counters = new int[max + 1];

    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i]]++;
    }

    int index = 0;

    for (int i = 0; i < counters.Length; i++)   
    {
        for (int j = 0; j < counters[i]; j++)  
        {
            sortedArray[index] = i;
            index++;
        }
    }
    return sortedArray;

}
