using System;
using System.Collections.Generic;
using System.Text;

namespace pract9
{
    public struct Runner
    {
        public string[,] FillMatrix(string[,] matrix)
        {
            matrix = new string[8, 3];
            Random rnd = new Random();
            for (int i = 0; i < 8; i++)
            {
                matrix[i, 2] = rnd.Next(1, 30).ToString();
            }
            for (int i = 0; i < 8; i++)
            {
                matrix[i, 0] = (i + 1).ToString();
            }
            for (int i = 0; i < 8; i++)
            {
                matrix[i, 1] = "Имя " + (i + 1);
            }
            return matrix;
        }

        public string AverageValue (string [,] matrix)
        {

            Random rnd = new Random();
            int counter = 0;
            for (int i = 0; i < 8; i++)
            {
                counter += Convert.ToInt32(matrix[i, 2]);
            }
            counter /= 8;
            string counterText = counter.ToString();
            return counterText;
        }
    }
}
