using System;

class Program
{
    //static void Main(string[] args)
    //{
    //    int n = 12, sum = 0, average = 0;

    //    int[] arr = new int[n];

    //    Random rand = new Random();

    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        arr[i] = rand.Next(0, 100);
    //    }

    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        sum += arr[i];
    //    }

    //    average = sum / n;

    //    int[] newArr = new int[n];

    //    for (int i = 0; i < newArr.Length; i++)
    //    {
    //        if (i == 4)
    //        {
    //            newArr[i] = average;
    //        }
    //        else
    //        {
    //            newArr[i] = arr[i];
    //        }
    //    }

    //    Console.Write("Исходный массив: ");

    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        Console.Write(arr[i] + " ");
    //    }
    //    Console.WriteLine();

    //    Console.WriteLine("Среднее арифметическое исходного массива: {0}", average);

    //    Console.Write("Новый массив:    ");

    //    for (int i = 0; i < newArr.Length; i++)
    //    {
    //        Console.Write(newArr[i] + " ");
    //    }
    //    Console.WriteLine();
    //}


    //static void Main(string[] args)
    //{
    //    Random rnd = new Random();
    //    int[] nums = new int[10];
    //   for (int i = 0; i < 10; i++)
    //   {
    //       nums[i] = rnd.Next(-50, 50);
    //        Console.Write(nums[i] + " ");
    //    }
    //    Console.WriteLine("Исходный массив");
    //    int max = nums[0], s = 0;
    //    for (int i = 0; i < 10; i++)
    //    {
    //        if (max < nums[i])
    //            max = i;
    //    }
    //    s = nums[0];
    //    nums[0] = nums[max];
    //    nums[max] = s;
    //    for (int i = 0; i < 10; i++)

    //        Console.Write(nums[i] + " ");
    //}
    //    static void Main(string[] args)
    //{
    //         Random rand = new Random();
    //         int[] arr = new int[20];
    //         int countEven = 0;
    //         int countOdd = 0;

    //         for(int i=0; i<20; i++)
    //         {
    //             arr[i] = rand.Next(1, 20);
    //             if (arr[i] % 2 == 0) countEven++;
    //                 else countOdd++;
    //             Console.Write(arr[i] + " ");
    //         }
    //         Console.WriteLine();
    //         if (countEven > countOdd) Console.WriteLine("Четных элементов больше");
    //         else
    //             if (countEven < countOdd) Console.WriteLine("Нечетных элементов больше");
    //         else Console.WriteLine("Равное количество элементов");
    //         Console.ReadLine();
    //      }
    //private static void Main(string[] args)
    //{
    //    var arr = new double[15];
    //    var count = 0;
    //    var random = new Random();
    //    arr[0] = Math.Round(random.NextDouble() + random.Next(1, 10), 2);
    //    Console.Write(arr[0] + " ");
    //    for (int i = 1; i < arr.Length; i++)
    //    {
    //        arr[i] = Math.Round(random.NextDouble() + random.Next(1, 10), 2);
    //        if (arr[i] > arr[0])
    //        {
    //            count++;
    //        }
    //        Console.Write(arr[i] + " ");
    //    }
    //    Console.WriteLine();
    //    Console.WriteLine(count);
    //    Console.ReadKey();
    //}



    //    static void Main(string[] args)
    //{
    //    double[] n = new double[16];
    //    Random rand = new Random();
    //    int mini = 0;
    //    int maxi = 0;
    //    Console.WriteLine("Введены 16 элементов массива: ");
    //    for (int i = 0; i < n.Length; i++)
    //    {
    //        n[i] = rand.Next(16);
    //        Console.WriteLine(n[i] + " ");
    //    }
    //    double min = n[0];
    //    double max = n[0];

    //    for (int i = 0; i < n.Length; i++)
    //    {
    //        if (max < n[i])
    //        {
    //            max = n[i]; maxi = i;
    //        }
    //        if (min > n[i])
    //        {
    //            min = n[i]; mini = i;
    //        }
    //    }
    //    Console.WriteLine("Результат:");
    //    Console.WriteLine("Максимальный элемент = {0};{1} ", max, maxi);
    //    Console.WriteLine("Минимальный элемент = {0};{1} ", min, mini);
    //    Console.ReadKey();
    //}
    //static void Main(string[] args)
    //{
    //    int[] v = new int[15];
    //    Random rnd = new Random();
    //    int summ = 0;
    //    string? s = null;


    //    for (int i = 0; i < 15; i++)
    //    {
    //        v[i] = rnd.Next(1, 100);
    //        s = s + v[i].ToString() + " ";
    //        summ = summ + v[i];
    //    }
    //    Console.WriteLine("Начальный массив = " + s);
    //    Console.WriteLine("Среднее арифметическое = " + (summ / 15));
    //    s = null;
    //    for (int i = 0; i < 15; i++)
    //    {
    //        v[i] = v[i] - (summ / 15);
    //        s = s + v[i].ToString() + " ";
    //    }
    //    Console.WriteLine("Новый массив = " + s);
    //    Console.ReadKey();
    //}
    //static void Main(string[] args)
    //{
    //    int n = 17, sum = 0, average = 0;

    //    int[] arr = new int[n];

    //    Random rand = new Random();

    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        arr[i] = rand.Next(0, 100);
    //    }

    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        sum += arr[i];
    //    }

    //    average = sum / n;

    //    int[] newArr = new int[n];

    //    for (int i = 0; i < newArr.Length; i++)
    //    {
    //        if (i == 4)
    //        {
    //            newArr[i] = average;
    //        }
    //        else
    //        {
    //            newArr[i] = arr[i];
    //        }
    //    }

    //    Console.Write("Исходный массив: ");

    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        Console.Write(arr[i] + " ");
    //    }
    //    Console.WriteLine();

    // Console.WriteLine("Больше среднеарифметического числа: {0}", average);
    //    Console.Write("Новый массив:    ");

    //    for (int i = 0; i < newArr.Length; i++)
    //    {
    //        Console.Write(newArr[i] + " ");
    //    }
    //    Console.WriteLine();
    //}

    //private static void Main(string[] args)
    //{
    //    int[] numbers = new int[12];
    //    Random random = new Random();


    //    for (int i = 0; i < 12; i++)
    //    {
    //        numbers[i] = random.Next(1, 100); 
    //    }


    //    Array.Sort(numbers);
    //    Array.Reverse(numbers);


    //    Console.WriteLine("Отсортированный массив в порядке убывания:");
    //    foreach (int num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    int sumMinMax = numbers[0] + numbers[numbers.Length - 1];

    //    Console.WriteLine("\n\nСумма максимального и минимального элементов: " + sumMinMax);

    //    Console.ReadLine();
    //}

    //static void Main()
    //{
        
    //    int[] numbers = new int[15];
    //    Random random = new Random();

        
    //    for (int i = 0; i < 15; i++)
    //    {
    //        numbers[i] = random.Next(1, 100); // Генерация случайных чисел от 1 до 100
    //    }

        
    //    int max = numbers[0];
    //    int min = numbers[0];

    //    for (int i = 1; i < 15; i++)
    //    {
    //        if (numbers[i] > max)
    //        {
    //            max = numbers[i];
    //        }
    //        if (numbers[i] < min)
    //        {
    //            min = numbers[i];
    //        }
    //    }

        
    //    int sum = max + min;
    //    int diff = max - min;

        
    //    Console.WriteLine("Массив случайных целых чисел:");
    //    foreach (int num in numbers)
    //    {
    //        Console.Write(num + " ");
    //    }

    //    Console.WriteLine("\n\nСумма максимального и минимального элементов: " + sum);
    //    Console.WriteLine("Разность максимального и минимального элементов: " + diff);

    //    Console.ReadLine();
    //}


}








