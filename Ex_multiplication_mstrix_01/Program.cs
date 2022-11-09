
const int N = 1000; // N - размер матрицы; const - значит размер матрицы не изменится
const int THREADS_NUMBER = 10; // создадим 8 потоков
// создаем массивы в которых будем хранить результаты
int[,] serialMulRes = new int[N, N]; // результат выполнения умножения матриц в однопотоке
int[,] threadMulRes = new int[N, N]; // результат паралельного умножения матриц 

int[,] firstMatrix = MatrixGenerator(N, N); // заполнили 1ую матрицу случайными числами
int[,] secondMatrix = MatrixGenerator(N, N); // заполнили 2ую матрицу случайными числами

SerialMatrixMul(firstMatrix, secondMatrix);
PrepareParallelMatrixMul(firstMatrix, secondMatrix);
Console.WriteLine(EqualityMatrix(serialMulRes, threadMulRes));

// генерируем матрицу рандомным образом 1000 на 1000

int[,] MatrixGenerator(int rows, int columns)
{
    Random _rand = new Random();
    int[,] res = new int[rows, columns];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = _rand.Next(-100, 100);
        }
    }
    return res;
}


// метод, который позволит умножить матрицы друг на друга

void SerialMatrixMul(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Нельзя умножить такие матрицы");
    // если в 1 матрице число столбцов не равно числу строк во 2 матрице -> тогда мы остановим программу
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)   // 3 цикл для умножения матриц
            {
                serialMulRes[i, j] += a[i, k] * b[k, j];
            }
        }
    }
}

// метод для подготовки паралеливания матриц

void PrepareParallelMatrixMul(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Нельзя умножить такие матрицы");
    int eachThreadCalc = N / THREADS_NUMBER;        // сколько вычислений будет приходиться на каждый поток    
    Thread[] arr = new Thread[2];
    var threadsList = new List<Thread>();     // подготавливается массив    
    for (int i = 0; i < THREADS_NUMBER; i++) 
    {
        int startPos = i * eachThreadCalc;
        int endPos = (i + 1) * eachThreadCalc;
        // если последний поток 
        if (i == THREADS_NUMBER - 1) endPos = N;   // дойти до конца матрицы
        threadsList.Add(new Thread(() => ParallelMatrixMul(a, b, startPos, endPos))); // создаем новый поток и делаем вызов умножения матрицы для потока
        threadsList[i].Start();   // запускам поток
    }
    for (int i = 0; i < THREADS_NUMBER; i++)         // подождать пока потоки закончат работу
    {
        threadsList[i].Join();
    }
}

// паралельная функция 
void ParallelMatrixMul(int[,] a, int[,] b, int startPos, int endPos)
{
    for (int i = startPos; i < endPos; i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                threadMulRes[i, j] += a[i, k] * b[k, j];
            }
        }
    }
}

bool EqualityMatrix(int[,] fmatrix, int[,] smatrix)
{
    bool res = true;
    for (int i = 0; i < fmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < fmatrix.GetLength(1); j++)
        {
            res = res && (fmatrix[i, j] == smatrix[i, j]);
        }
    }
    return res;
}


