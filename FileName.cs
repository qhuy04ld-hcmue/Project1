using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class FileName
    {
        static bool kt(int n)
        {
            if (n < 2) return false;
            if (n==2) return true;
            if (n > 2)
            {
                for (int i = 2; i < n; i++)
                    if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so dong, cot: ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            int i, j;
            for (i=0;i < n;i++) 
                for (j=0;j<m;j++)
                    a[i,j]=int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                    Console.Write("{0} ", a[i,j]);
                Console.WriteLine();
            }
            Console.WriteLine("\nCac so nguyen to trong day: ");
            for (i=0 ; i < n ; i++)
                for (j=0;j < m ; j++)
                {
                    if (kt(a[i, j]))
                    {
                        Console.Write("{0} ", a[i, j]);
                    } 
                }
            
            Console.ReadKey();
        }
    }
}
