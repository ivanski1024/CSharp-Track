using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMatrix
{
    class Matrix<T>
    {
        private int rows, cols;
        private T[,] matrix;

        public int Rows
        {
            get
            {
                return rows;
            }
        }
        public int Cols
        {
            get
            {
                return cols;
            }
        }

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.matrix = new T[rows, cols];
        }
        public T this[int row, int col]
        {
            get
            {
                return matrix[row, col];
            }
            set
            {
                matrix[row, col] = value;
            }
        }
        public Matrix<T> operator +(Matrix<T> A, Matrix<T> B)
        {
            if (A.Rows != B.Rows && A.Cols != B.Cols)
            {
                throw new InvalidOperationException("Matrixes are not in the same size");
            }
            else
            {
                Matrix<T> Sum = new Matrix<T>(A.Rows, A.Cols);
                for (int row = 0; row < A.Rows; row++)
                {
                    for (int col = 0; col < A.Cols; col++)
                    {
                        //A[row, col].
                        Sum[row, col] = (dynamic)A[row, col] + (dynamic)B[row, col];
                    }
                }
                
            }
        }
        public Matrix<T> operator -(Matrix<T> A, Matrix<T> B)
        {
            if (A.Rows != B.Rows && A.Cols != B.Cols)
            {
                throw new InvalidOperationException("Matrixes are not in the same size");
            }
            else
            {
                Matrix<T> Sum = new Matrix<T>(A.Rows, A.Cols);
                for (int row = 0; row < A.Rows; row++)
                {
                    for (int col = 0; col < A.Cols; col++)
                    {
                        //A[row, col].
                        Sum[row, col] = (dynamic)A[row, col] - (dynamic)B[row, col];
                    }
                }

            }
        }
        public Matrix<T> operator *(Matrix<T> A, Matrix<T> B)
        {
            if (A.Cols != B.Rows)
            {
                throw new InvalidOperationException("Cols of the first matrix should be equal to rows of second matrix.");
            }
            else 
            {
                Matrix<T> Product = new Matrix<T>(A.Rows, B.Cols);
                for (int row = 0; row < A.Rows; row++)
                {
                    for (int col = 0; col < B.Cols; col++)
                    {
                        Product[row, col] = (dynamic)0;
                        for (int el = 0; el < A.Cols; el++)
                        {
                            Product += (dynamic)A[row, el] * (dynamic)B[el, col];
                        }
                    }
                }
                return Product;
            }
        }
        public bool operator true[int row, int col]
        {
            return matrix[row, col]!=0;
        }
    }
}
