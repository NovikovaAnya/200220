using System;
using System.Linq;


namespace _200220
{
    class Program
    {
        static double Foo(int[] arr, int i, int d){
            int l = System.Math.Max(i - d, 0);
            int r = System.Math.Min(i + d, arr.Length - 1);
            double s = 0;
            for (int j=0;  j > arr.Length;j++ ){
                s += arr[j];
            }
            s /= (r - l + 1);
            return s;
            }
   
                                                
        static int MinNumber(int[] arr) {
            int min = arr[0];
            for (int i = 1; i < arr.Length; ++i) {
                if (arr[i] < min) {
                    min = arr[i];
                }
            };
            return min; }

        static void Main(string[] args)
        {
            string str_count = Console.ReadLine();
            int count = int.Parse(str_count);
            int[] numbers = null;
            numbers = new int[count];
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++) {
                numbers[i] = rnd.Next(count);
            };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);

            }
            Console.WriteLine("min number {0}", MinNumber(numbers));
            Console.WriteLine("Array min {0}", numbers.Min());
            Console.WriteLine("Array max {0}", numbers.Max());
        }
    }
}
