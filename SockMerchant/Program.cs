using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SockMerchant
{
    class Program
    {
        static int SockMerchant (int[] ar)
        {
            return ar.GroupBy(a => a).Sum(a => a.Count() / 2);
        }


        // Complete the sockMerchant function below.
        static int SockMerchant(int n, int[] ar)
        {
            int temp = 0;
            int count = 1;
            int totalCount = 0;
            if (n >= 1 && n <= 100)
            {
                Array.Sort(ar, 0, n);


                //Console.WriteLine("***********");
                //PRINT SORTED ARRAY
                //foreach (int ii in ar)
                //{

                //    Console.Write(ii);
                //    Console.Write(" ");
                //}
                //Console.WriteLine("***********");


                for (int i = 0; i < n; i++)
                {
                    count = 1;
                    if (temp != ar[i])
                    {
                        for (int j = i + 1; j < ar.Length; j++)
                        {
                            //temp = ar[i+1];
                            if (ar[i] == ar[j])
                            {
                                count += 1;
                                temp = ar[i];
                            }
                        }

                        if (count % 2 == 0)
                        {
                            totalCount += count / 2;
                        }
                        else if (count % 2 != 0 && count > 2)       // if count = 1 ==>> initialization no use here
                        {
                            totalCount += (count - 1) / 2;
                        }
                    }
                }
            }
            return totalCount;


        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

           // int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

           int[] ar = new int[] { 50, 20, 20, 10, 30, 30, 50, 10, 20, 14, 14 };
           //int result = SockMerchant(n, ar);
           int result = SockMerchant(ar);   // call LINQ Solution

            Console.WriteLine(result);
            Console.ReadLine();
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }

}

