// Сортировка подсчетом 3 (с отрицательными числами)

int[] array = {-5, 100, -99, 88, 36, 4, 6};

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
    int min = inputArray.Min();    // получаем минимальный элемент

    int offset = -min;   // смещение на мин число
    int[] sortedArray = new int[inputArray.Length];  // новый массив
    int[] counters = new int[max + offset + 1];

    Console.WriteLine(max + offset + 1); // на сколько элеменов выделился массив

    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i] + offset]++;
    }

    int index = 0;

    for (int i = 0; i < counters.Length; i++)   
    {
        for (int j = 0; j < counters[i]; j++)  
        {
            sortedArray[index] = i - offset;
            index++;
        }
    }
    return sortedArray;
}
