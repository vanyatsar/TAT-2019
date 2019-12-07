using System;
using System.Collections.Generic;
using System.Linq;


namespace Matrix
{
    public class Matrix <T>
    {
        int n;
        T[] matrix;

        delegate void IsChanged(string message);
        event IsChanged Change;
        public Matrix()
        { 
        }
        public Matrix(int n, T[] matrix)
        {
            this.n = n;
            this.matrix = new T[n * n];
            this.matrix = matrix;
        }

        public T this[int i, int j]
        {
            get
            {
                return matrix[n * i + j];
            }
            set
            {
                Change += Message;
                Change?.Invoke($"Значение {n * i + j} изменено на {value}");
                matrix[n * i + j] = value;
            }
        }
        public bool IsDiagonal()
        {
            bool check = true;
           
            for (int i = 0; i < n; i++)
            {
                for (int j = 0;  j < n;  j++)
                {
                    if (i!= j && !IsNullOrDefaultValue(matrix[n * i + j]))
                    {
                        check = false;
                        break;
                    }
                }
            }
            return check;
        }
        public void Message(string message)
        {
            Console.WriteLine(message);
        }

        private bool IsNullOrDefaultValue(T value)
        {
            return object.Equals(value, default(T));
        }
    }
}
