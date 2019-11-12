using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 3;
           
            string[] a = new string[] { "123", "dd", null, null, null, null, null, null, null };
            Matrix<string> A = new Matrix<string>(size, a);
            Console.WriteLine(A.IsDiagonal());
            
            int[] b = new int[] { 1, 1, 0, 0, 1, 0, 0, 0, 1 };
            Matrix<int> B = new Matrix<int>(size, b);
            Console.WriteLine(B.IsDiagonal());
            
            string i = A[2, 2];
            int j = B[2, 2] = 4;
        }
    }
}
