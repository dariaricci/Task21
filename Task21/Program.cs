using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task21
{
    class Program
    {
        const int n= 5;
        static int[,] t = new int[n, n];
        static void Main(string[] args)
        {

            ThreadStart threadStart = new ThreadStart(Sadovnik1);
            Thread thread = new Thread(threadStart);
            thread.Start();
            Sadovnik2();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(t[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }

        public static void Sadovnik1()
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (t[i, j] != 2)
                    {
                        t[i, j] = 1;
                        
                        
                    }
                    Thread.Sleep(5);
                    
                }
                

            }
           
        }
        public static void Sadovnik2()
        {
           
            for (int j = n-1; j > 0; j--)
            {
                for (int i = n-1; i > 0; i--)
                {

                    if (t[i, j] != 1)
                    {
                        t[i, j] = 2;
                        


                    }
                    Thread.Sleep(20);


                }
                
            }

        }
    }
}
