using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Select__Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());   //读入数组长度

            Array A = new Array(n);    

            if (A.Random())    //随机赋值
            {
                Console.WriteLine("原始数组: ");
                A.DisplayMatrix();    //打印初始数组
            }
            if (A.select_sort())     //选择排序
            {
                Console.WriteLine("降序数组: ");
                A.DisplayMatrix();    //打印排序后的数组
            }

            Console.ReadKey();
        }
    }
}
