using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaTran
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n : ");int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n,n];
            // Nhap xuat ma tran
            Console.WriteLine("Nhap mang a ");
            for (int i = 0; i <n; i++)
            {
                for(int j = 0; j <n; j++)
                {
                    Console.Write(" a[{0},{1}] = ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            // xuat mang vua nhap
            Console.WriteLine("Mang vua nhap la : ");
            for (int i = 0; i <n; i++)
            {
                for (int j = 0; j <n; j++)
                {
                    Console.Write(" " + a[i, j]);
                }
                Console.WriteLine();
            }
            // tinh tong so le tren duong cheo chinh
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(i==j && a[i, j]% 2 != 0)
                    {
                        sum += a[i, j];
                    }
                }
            }
            Console.WriteLine("Tong so le tren duong cheo chinh la : " + sum);

            // chuyen cac phan tu am trong mang thanh phan tu duong
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] < 0)
                    {
                        a[i, j] = -a[i, j];
                    }
                }
            }
            Console.WriteLine("Hien thi :");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" " + a[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
