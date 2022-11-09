/* Сортировка подсчетом;  [ 0 ; 9 ] = цифры; нухно задать отдельный вспомогательный массив
Первоначальный массив [ 0 , 2 , 3 , 2 , 1 , 5 , 9 , 1 , 1 ] 

[ 1 , 3 , 2 , 1 , 0 , 1 , 0 , 0 , 0 , 1 ] - вспомогательный массив повторений
 [0] [1] [2] [3] [4] [5] [6] [7] [8] [9]
[ 0 , 1 , 1 , 1 , 2 , 2 , 3 , 5 , 9 ]  */

int[] array = {3, 2, 1, 5, 9};

CountingSort(array);

Console.WriteLine(string.Join(", ", array));

void CountingSort(int[] inputArray)
{
    int[] counters = new int[10];         // создаем вспомогательный массив "повторений" и выделяем под него память new int[10]

    //int OurNumber;

    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i]]++;
        //int ourNumber = inputArray[i];
        //counters[ourNumber]++;
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

