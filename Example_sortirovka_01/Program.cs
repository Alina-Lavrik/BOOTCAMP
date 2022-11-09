/* Сортировка методом выбора от минимального к максимальному
Замена
/*
[6, 15, 2, 9, -3]
MIN = 6
6 < 15
6 > 2
MIN = 2
2 < 9
2 > -3
MIN = -3
[-3, 6, 15, 2, 9]
[6, 15, 2, 9]
MIN = 6
6 < 15
6 > 2
MIN = 2
2 < 9
[-3, 2, 6, 15, 9]
MIN = 6
6 < 15
6 < 9
[-3, 2, 6, 15, 9]
MIN = 15
15 > 9
[-3, 2, 6, 9, 15]
*/

Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());   // ReadLine считывает строку; Convert.ToInt32 - переводит в целое число
// Заполнение массива
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());  // записываем число, которое пользователь введет в терминале
}
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]"); // Функция string.Join выводит все элементы массива array через ,
// Сортировка
for (int i = 0; i < n - 1; i++)   // n - размерность массива, n-1 -> чтобы не трогать последнее число тк оно нам не нужно
{
    int MinIndex = i;
    for (int j = i + 1; j < n; j++)
    {
        if (array[j] < array[MinIndex])
            MinIndex = j;
    }
    int temp;   // завлдим вспомогательную переменную для замены
    temp = array[MinIndex];  // в переменную кладем значение MinIndex
    array[MinIndex] = array[i];
    array[i] = temp;
}
Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");
