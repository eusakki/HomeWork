using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharMatrix
{
    class CharMatrix
    {
        private char[,] matrix;
        private int size;
        private int vowelCount;

        public CharMatrix(char[,] inputMatrix)
        {
            matrix = inputMatrix;
            size = matrix.GetLength(0);
            CountVowels();
        }

        public string this[int index]
        {
            get
            {
                if (index != 0 && index != 1)
                    throw new IndexOutOfRangeException("Індексатор приймає лише 0 (головна) або 1 (побічна) діагональ.");

                string diagonal = "";
                for (int i = 0; i < size; i++)
                {
                    if (index == 0)
                        diagonal += matrix[i, i];
                    else
                        diagonal += matrix[i, size - i - 1];
                }
                return diagonal;
            }
        }

        public int VowelCount
        {
            get { return vowelCount; }
        }

        private void CountVowels()
        {
            vowelCount = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U',
                'а', 'е', 'и', 'і', 'о', 'у', 'я', 'ю', 'є', 'ї', 'А', 'Е', 'И', 'І', 'О', 'У', 'Я', 'Ю', 'Є', 'Ї' };
            foreach (char c in matrix)
            {
                if (Array.Exists(vowels, v => v == c))
                    vowelCount++;
            }
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
