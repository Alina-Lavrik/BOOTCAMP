/* Пузырьковая сортировка
Сравниваем 2 первых элемента, затем 2-ой и 3-ий, затем 3-ий и 4-ый и тд

[3, 1, 5, 0, 7, 9, 8] - начальный массив

*/

Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine()); //Функция Convert.ToInt32 () преобразует данные, введенные пользователем в тип данных int
int[] array = new int[n];
for (int i = 0; i < n ; i++)
{
    Console.WriteLine("Введите значения массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine()); // заполнили массив
}
Console.WriteLine(" Начальный массив: [" + string.Join(", ", array) + "]");  // Функция string.Join выводит все элементы массива array через ,
Console.WriteLine();
// Запускаем главный цикл
//int temp;
for (int i = 0; i < n ; i++)  // число i - это кол-во проходов
{
    // int temp = 0;
    for (int j = 0; j < n - 1; j++)  // число j - проходимся по самому массиву
    {
        if(array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
}
