using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_6
{
    /// <summary>
    /// �����, ����������� ������ �������� 
    /// ��������� ��������� �������� ��� ���������  
    /// </summary>
    class Arrs
    {
        private static Random rnd = new Random();
        /// <summary>
        /// ���������� ������� ���������� �������
        /// � ��������� [1, 100]
        /// </summary>
        /// <param name="A">������, ���������� ����������</param>
        public static void CreateOneDimAr(int[] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
                A[i] = rnd.Next(1, 100);
        }//CreateOneDimAr
        /// <summary>
        /// ���������� ���������� ������� ���������� �������
        /// � ��������� [1, 100]
        /// </summary>
        /// <param name="A">������, ���������� ����������</param>
        public static void CreateTwoDimAr(int[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                A[i, j] = rnd.Next(1, 100);
        }//CreateTwoDimAr

        /// <summary>
        /// ������ �������
        /// </summary>
        /// <param name="name">��� �������</param>
        /// <param name="A"> ������</param>
        public static void PrintAr1(string name, int[] A)
        {
            Console.WriteLine(name);
            for (int i = 0; i < A.GetLength(0); i++)
                Console.Write("\t" + name + "[{0}]={1}", i, A[i]);
            Console.WriteLine();
        }//PrintAr1

        /// <summary>
        /// ������ ���������� �������
        /// </summary>
        /// <param name="name">��� �������</param>
        /// <param name="A"> ������</param>
        public static void PrintAr2(string name, int[,] A)
        {
            Console.WriteLine(name);
            for (int i = 0; i < A.GetLength(0); i++)
                {for (int j = 0; j < A.GetLength(1); j++ )                
                    Console.Write("\t" + name + 
                        "[{0},{1}] = {2}", i, j, A[i,j]);
                 Console.WriteLine();
                }
        }//PrintAr2

        /// <summary>
        /// ������ � ������������ �������� �������
        /// </summary>
        /// <param name="name">��� �������</param>
        /// <param name="n1">����� ����� </param>
        /// <param name="m1">����� ��������</param>
        public static void GetSizes(string name, out int n1, out int m1)
        {
            Console.WriteLine("��� ������� " + name +
                " ������� ����� " + "�����");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("��� ������� " + name +
                " ������� ����� " + "��������");
            m1 = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// ��������� ������ � = A * B
        /// </summary>
        /// <param name="A">������ �������</param>
        /// <param name="B">������ �������</param>
        /// <param name="C">��������� ��������� ������</param>
        public static void MultMatr(int[,] A, int[,] B, int[,] C)
        {
            if (A.GetLength(1) != B.GetLength(0))
                Console.WriteLine("MultMatr: ������ �����������!");
            else
                for (int i = 0; i < A.GetLength(0); i++)
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        int s = 0;
                        for (int k = 0; k < A.GetLength(1); k++)
                            s += A[i, k] * B[k, j];
                        C[i, j] = s;
                    }
        }//MultMatr

        
        /// <summary>
        /// ������ ������ "���� � ����",
        /// ��������� ��������� Fathers � Children
        /// </summary>
        /// <param name="Fathers">������ �����</param>
        /// <param name="Children"> ������ �������� �����</param>
        public static void PrintAr3(string[] Fathers, string[][] Children)
        {
            for (int i = 0; i < Fathers.Length; i++)
            {
                Console.WriteLine("���� : {0}; ��� ����:", Fathers[i]);
                for (int j = 0; j < Children[i].Length; j++)
                    Console.Write(Children[i][j] + " ");
                Console.WriteLine();
            }
        }//PrintAr3
    }
}
