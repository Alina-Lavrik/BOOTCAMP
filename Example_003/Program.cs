// O (n^2)
// Таблица умножения
int n = Convert.ToInt32(Console.ReadLine()); // Введем число и укажем его
for(int i = 1; i <= n; i++)
{
    for(int j = 1; j <= n; j++)
    {
        Console.Write(i * j);
        //Console.Write(" ");
        Console.Write("\t");
    }
    Console.WriteLine();
}

