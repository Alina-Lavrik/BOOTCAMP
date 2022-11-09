
int[] array = new int[5];  // заводим массив на 5 элементов, там будут храниться только целые числа int
for (int i = 0 ; i < 5; i++)                            // заполним массив целыми числами
      array[i] = Convert.ToInt32(Console.ReadLine());  // Функция Convert.ToInt32 () преобразует данные, введенные пользователем в тип данных int
Console.WriteLine("[" + string.Join(", ", array) + "]");  // Функция Join выводит все элементы массива 
Console.WriteLine(array[3]);
// Сложность алгоритма 0(1)