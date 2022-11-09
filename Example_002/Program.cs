// массив [ 4, 5, 3, 1, 2]
// O(n) - количество операций, время работы
// сумма элементов массива
int n = 5;
int[] array = new int[n];  
for (int i = 0 ; i < n; i++)                           
      array[i] = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine("[" + string.Join(", ", array) + "]");  

int summa = 0;
for (int i = 0; i < n; i++)
    summa += array[i];
Console.WriteLine(summa);