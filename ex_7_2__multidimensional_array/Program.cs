using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_7_2__multidimensional_array
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 7-2  Multidimensional Arrays 
            1.Create a two dimensional array of type integer with four elements on each row. 
            2.Fill it in with whatever numbers you would like. 
            3.Print to the console the first element of the first row. 
            4.Print to the console the third element of the second row. 
            5.Each dimension of a multidimensional array has its own length. 
            6.Find the lengths for you multidimensional array. 
            7.Print to the console all of the elements.*/


            //1.Create a two dimensional array of type integer with four elements on each row. 
            int[,] intMatrix = new int[2, 4];
            //2.Fill it in with whatever numbers you would like. 
            int[,] matrix =
            {
                {1, 2, 3, 4}, // row 0 values
                {5, 6, 7, 8}, // row 1 values
            };

            //3.Print to the console the first element of the first row. 
            Console.WriteLine(matrix[0, 0]);

            //4.Print to the console the third element of the second row. 
            Console.WriteLine(matrix[1, 2]);

            //5.Each dimension of a multidimensional array has its own length. 
            // The matrix size is 2 x 4 (2 rows, 4 cols)

            //6.Find the lengths for you multidimensional array. 
            Console.WriteLine("number of rows= " + matrix.GetLength(0));
            Console.WriteLine("number of columns= " + matrix.GetLength(1));

            //7.Print to the console all of the elements.
            // Print the matrix on the console
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
