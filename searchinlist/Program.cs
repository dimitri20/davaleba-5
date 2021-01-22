using System;
using System.Collections.Generic;

namespace searchinlist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> libr = new List<int>(){23,123,24,53,1,22,5,46,4,21,64,12,3,4,5,1,2,8,67,45,363,234,123,546,867,435};
            string result = "";
            while(true)
            {
                Console.Write("sheiyvanet sadziebo ricxvi: ");
                int input = Convert.ToInt32(Console.ReadLine());
                for(int i = 0; i < libr.Count; i++){
                    if (libr[i] == input){
                        result = $"siashi aris ricxvi indexze -- {i}";
                        break;
                    } else {
                        result = "-1";
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
