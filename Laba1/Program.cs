using System;
using System.IO;
using System.Text;
using System.Linq;


namespace Laba1
{

    class Program
    {

        static int GetRandom()
        {
            
            Random rand = new Random();
            int value = rand.Next(-30, 31);
            return value;
        }

        static void Clear()
        {
            Console.Clear();
        }

        static void DefaultArray()
        {
                Console.WriteLine("Выберите тип ввода массива: \na. Ручной  \nb. Из файла");
                string DefaulArrayOption = Console.ReadLine();
                Clear();
                switch (DefaulArrayOption)
                {
                    case "a":

                        Console.Write("Введите количество элементов массива: ");
                        int elementsCount = int.Parse(Console.ReadLine());
                        int[] myArray = new int[elementsCount];

                        for (int i = 0; i < myArray.Length; i++)
                        {
                            myArray[i] = GetRandom();
                        }



                        Console.WriteLine("\nВведенный массив:");
                        foreach (int number in myArray)
                        {
                            Console.Write($"{number} \t");
                        }
                        Console.ReadKey();
                        Clear();

                        Console.WriteLine("Выполнить сортировку? \na. Да \nb. Нет");
                        string SortFirst = Console.ReadLine();
                        Clear();

                        switch (SortFirst)
                        {
                            case "a":
                                Console.WriteLine($"Максимальное значение массива: {myArray.Max()}");
                                Console.WriteLine($"Минимальное значение массива: {myArray.Min()}");
                                Array.Sort(myArray);
                                Console.WriteLine("\nВывод отсортированного массива");
                                foreach (int number in myArray)
                                {
                                    Console.Write($"{number} \t");
                                }
                                Array.Sort(myArray);
                                Array.Reverse(myArray);
                                Console.WriteLine("\n\nВывод обратно отсортированного массива");
                                foreach (int number in myArray)
                                {
                                    Console.Write($"{number} \t");
                                }
                                int nArrayLength = 0;
                                for (int i = 0; i < myArray.Length; i++)
                                {
                                    if (myArray[i] % 2 == 0)
                                    {
                                        nArrayLength++;
                                    }
                                }
                                int[] nArray = new int[nArrayLength];
                                for (int i = 0, j = 0; i < myArray.Length; i++)

                                {
                                    if (myArray[i] % 2 == 0)
                                    {
                                        nArray[j] = myArray[i];
                                        j++;
                                    }
                                }
                                Console.WriteLine("\n\nМассив с четными числами");
                                foreach (int number in nArray)
                                {
                                    Console.Write($"{number} \t");
                                }

                                break;

                            case "b":
                                Console.WriteLine("Возвращение к меню...");
                                break;

                            default:
                                Console.WriteLine("Выбран неизвестный пункт, попробуйте снова");
                                return;

                        }
                        break;

                    case "b":
                        int[] ArrayFL = File.ReadAllText("D://Lab1.txt", Encoding.Default).Split(' ').Select(x => int.Parse(x)).ToArray();
                        Console.WriteLine("Введенный массив:");

                        foreach (int number in ArrayFL)
                        {
                            Console.Write($"{number} \t");
                        }
                        Console.WriteLine("\n\nВыполнить сортировку? \na. Да \nb. Нет");
                        string SortFirstFL = Console.ReadLine();
                        Clear();

                        switch (SortFirstFL)
                        {
                            case "a":
                                Console.WriteLine($"Максимальное значение массива: {ArrayFL.Max()}");
                                Console.WriteLine($"Минимальное значение массива: {ArrayFL.Min()}");
                                Array.Sort(ArrayFL);
                                Console.WriteLine("\nВывод отсортированного массива");
                                foreach (int number in ArrayFL)
                                {
                                    Console.Write($"{number} \t");
                                }
                                Array.Sort(ArrayFL);
                                Array.Reverse(ArrayFL);
                                Console.WriteLine("\n\nВывод обратно отсортированного массива");
                                foreach (int number in ArrayFL)
                                {
                                    Console.Write($"{number} \t");
                                }
                                int nArrayLength = 0;
                                for (int i = 0; i < ArrayFL.Length; i++)
                                {
                                    if (ArrayFL[i] % 2 == 0)
                                    {
                                        nArrayLength++;
                                    }
                                }
                                int[] nArray = new int[nArrayLength];
                                for (int i = 0, j = 0; i < ArrayFL.Length; i++)

                                {
                                    if (ArrayFL[i] % 2 == 0)
                                    {
                                        nArray[j] = ArrayFL[i];
                                        j++;
                                    }
                                }
                                Console.WriteLine("\n\nМассив с четными числами");
                                foreach (int number in nArray)
                                {
                                    Console.Write($"{number} \t");
                                }

                                break;

                            case "b":
                                Console.WriteLine("Пока");
                                break;

                            default:
                                Console.WriteLine("Выбран неизвестный пункт, попробуйте снова");
                                return;

                        }
                        break;

                    default:
                        Console.WriteLine("Выбран неизвестный пункт, попробуйте снова");
                        break;
                        
                
            }
        }

        static void MatrixArray()
        {
            Console.Write("Введите кол-во строк: ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Ввдетие кол-во столбцов: ");
            int Y = int.Parse(Console.ReadLine());
            int[,] matArray = new int[X, Y];
            for (int i = 0; i < matArray.GetLength(0); i++)
            {
                for (int j = 0; j < matArray.GetLength(1); j++)
                {
                    matArray[i, j] = GetRandom();
                }

            }

            string[] lines = File.ReadAllLines("D://Lab1_2.txt");
            int[,] matArrayFL = new int[lines.Length, lines[0].Split(' ').Length];
            
            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(' ');
                for (int j = 0; j < temp.Length; j++)
                {
                    matArrayFL[i, j] = Convert.ToInt32(temp[j]);
                } 
            }

            Clear();
            Console.WriteLine("\nМассив из файла");
            for (int i = 0; i < matArrayFL.GetLength(0); i++)
            {
                for (int j = 0; j < matArrayFL.GetLength(1); j++)
                {
                    Console.Write(matArrayFL[i, j] + "\t");
                }
                Console.WriteLine();
            }
            

            int height = matArray.GetLength(0);
            int width = matArray.GetLength(1);
            Console.WriteLine("\nВведенный массив:");
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(matArray[y, x] + "\t");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("\n\nВыполнить сортировку? \na. Да \nb. Нет");
            string SecondSort = Console.ReadLine();
            Clear();
            switch (SecondSort)
            {
                case "a":
                    
                    var max = (from int x in matArray select x).Max();
                    var min = (from int x in matArray select x).Min();
                    Console.WriteLine($"Максимальное значение введенной матрицы: {max}");
                    Console.WriteLine($"Минимальное значение введенной матрицы: {min}");

                    var maxFL = (from int x in matArrayFL select x).Max();
                    var minFL = (from int x in matArrayFL select x).Min();
                    Console.WriteLine($"\nМаксимальное значение матрицы из файла: {maxFL}");
                    Console.WriteLine($"Минимальное значение матрицы из файла: {minFL}");
                   
                    Console.WriteLine();

                    for (short i = 0; i < X; i++)
                    {
                        int sum = 0;
                        for (short j = 0; j < Y; j++)
                        {
                            sum += matArray[i, j];
                        }
                        Console.WriteLine("Сумма в {0} строке: {1}", i, sum);
                    }
                    Console.WriteLine();

                    if (matArray.GetLength(1) != matArrayFL.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
                    int[,] r = new int[matArray.GetLength(0), matArrayFL.GetLength(1)];
                    for (int i = 0; i < matArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < matArrayFL.GetLength(1); j++)
                        {
                            for (int k = 0; k < matArrayFL.GetLength(0); k++)
                            {
                                r[i, j] += matArray[i, k] * matArrayFL[k, j];
                            }
                        }
                    }

                    Console.WriteLine("Перемноженная матрица");
                    for (int i = 0; i < r.GetLength(0); i++)
                    {
                        for (int j = 0; j < r.GetLength(1); j++)
                        {
                            Console.Write(r[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    break;

                case "b":
                    Console.WriteLine("Возвращение к меню...");
                    break;

                default:
                    Console.WriteLine("Выбран неизвестный пункт, попробуйте снова");
                    return;
            }
        }
        
        static void ZubArray()
        {
            //Console.Write("Введите количество массивов: ");
            //int lines = int.Parse(Console.ReadLine());
            //int[][] ZubDefArray = new int[lines][];

            //for (int i = 0; i < ZubDefArray.Length; i++)
            //{
            //    for (int j = 0; j < ZubDefArray[i].Length; j++)
            //    {
            //        ZubDefArray[i][j] = GetRandom();
            //    }
            //}

            //Console.WriteLine("\nВведенный массив:");
            //for (int i = 0; i < ZubDefArray.Length; i++)
            //{
            //    for (int j = 0; j < ZubDefArray[i].Length; j++)
            //    {

            //    }
            //    Console.WriteLine();
            //}

        }

        static void Main(string[] args)
        {
            string userCommand = Console.ReadLine();
            Console.Write("Это обычная программа для работы с разными массивами. \nНажмите Enter для продолжения: ");
            Console.ReadKey();
            Console.WriteLine();
            Console.Clear();
            while (userCommand != "Да")
            {
                Console.WriteLine("С каким массивовом Вы хотите начать работу? \n\na. С обычным \nb. С матричным \nc. С зубчатым \nd. Выход");
                string Way = Console.ReadLine();
                Clear();
                switch (Way)
                {
                    case "a":
                        DefaultArray();
                        Console.WriteLine("\n\nВыйти из программы? Да/Нет");
                        userCommand = Console.ReadLine();
                        Clear();
                        break;

                    case "b":
                        MatrixArray();
                        Console.WriteLine("\n\nВыйти из программы? Да/Нет");
                        userCommand = Console.ReadLine();
                        Clear();
                        break;

                    case "c":
                        ZubArray();
                        Console.WriteLine("\n\nВыйти из программы? Да/Нет");
                        userCommand = Console.ReadLine();
                        break;

                    case "d":
                        Console.WriteLine("Выйти из программы? Да/Нет");
                        userCommand = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Выбран неизвестный пункт, повторите попытку");
                        Console.ReadKey();
                        Clear();
                        break;
                }
            
            }
            
        }
    }
}
