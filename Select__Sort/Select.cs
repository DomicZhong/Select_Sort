using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Select__Sort
{
    class Array
    {
        private int[] A;

        public Array(int n)   //构造函数，输入数组长度
        {
            A = new int[n];
        }

        public bool Random()   //随机赋值函数
        {
            Random rNum = new Random();
            //数组A赋值(0~100之间的随机数)
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rNum.Next(101);
            }
            return true;
        }

        public bool select_sort()  //选择排序
        {
            int MaxI, t, i;
            //选择法递减排序
            int N = A.Length; //获取数组A的长度N
            for (int loop = 0; loop <= N - 2; loop++)//外循环进行N-1轮比较
            {
                MaxI = loop;
                for (i = loop; i <= N - 1; i++)    //内循环中在无序数中找最大值
                    if (A[i] > A[MaxI]) MaxI = i;
                //最大值与无序数中的第一个元素交换
                t = A[loop];
                A[loop] = A[MaxI];
                A[MaxI] = t;
            }
            return true;
        }

        public bool DisplayMatrix() //打印数组
        {
            foreach (int i in A)
            {
                Console.Write("{0,4} ", i);
            }
            Console.WriteLine();
            return true;
        }
    }
}
