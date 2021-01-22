using System;

namespace multipleOfTen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            int countMultipleOfTen = 0;
            
            //masivis shevseba 
            for(int i = 0; i < arr.Length; i++){
                Console.Write("shemoiyvanet ricxvi: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (arr[i] % 10 == 0 && arr[i] % 3 == 0){
                    countMultipleOfTen++;
                }
            }

            Console.WriteLine($"masivshi atisa da samis jeradi ricxvebis raodenobaa:  {countMultipleOfTen}");

        }
    }
}
