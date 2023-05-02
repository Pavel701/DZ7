class Program {
    static void Main() {
        // размер массива
        int m = 3;
        int n = 4;

        // создание двумерного массива
        double[,] matrix = new double[m, n];

        // заполнение массива случайными вещественными числами
        Random random = new Random();
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                matrix[i, j] = random.NextDouble();
            }
        }

        // вывод массива на консоль
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}



