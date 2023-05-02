// class Program {
//     static void Main() {
//         int m = 3; // количество строк массива
//         int n = 4; // количество столбцов массива
        
//         double[,] array = new double[m, n]; // создаем пустой двумерный массив заданного размера

//         Random rand = new Random(); // создаем генератор случайных чисел

//         // заполняем массив случайными вещественными числами
//         for (int i = 0; i < m; i++) {
//             for (int j = 0; j < n; j++) {
//                 array[i, j] = rand.NextDouble();
//             }
//         }

//         // выводим массив на экран
//         for (int i = 0; i < m; i++) {
//             for (int j = 0; j < n; j++) {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }


// class Program {
//     static void Main() {
//         // размер массива
//         int m = 4;
//         int n = 5;
        
//         int[,] matrix = new int[m, n]; // создание двумерного массива

//         // заполнение массива
//         for (int i = 0; i < m; i++) {
//             for (int j = 0; j < n; j++) {
//                 matrix[i, j] = i * n + j;
//             }
//         }

//         Console.WriteLine("Введите номер строки:"); // чтение позиций элементов с консоли
//         int row = int.Parse(Console.ReadLine());
//         Console.WriteLine("Введите номер столбца:");
//         int col = int.Parse(Console.ReadLine());

//         // проверка наличия элемента в массиве и его вывод
//         if (row >= 0 && row < m && col >= 0 && col < n) {
//             Console.WriteLine($"Значение элемента [{row}, {col}]: {matrix[row, col]}");
//         } else {
//             Console.WriteLine("Такого числа в массиве нет!");
//         }
//     }
// }

class Program {
    static void Main() {
        // размер массива
        int m = 4;
        int n = 5;

        // создание двумерного массива
        int[,] matrix = new int[m, n];

        // заполнение массива
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                matrix[i, j] = i * n + j;
            }
        }

        // вычисление среднего арифметического значения в каждом столбце
        double[] columnMeans = new double[n];
        for (int j = 0; j < n; j++) {
            int sum = 0;
            for (int i = 0; i < m; i++) {
                sum += matrix[i, j];
            }
            columnMeans[j] = (double)sum / m;
        }

        // вывод среднего арифметического значения для каждого столбца на консоль
        for (int j = 0; j < n; j++) {
            Console.WriteLine($"Среднее арифметическое столбца {j}: {columnMeans[j]}");
        }
    }
}
