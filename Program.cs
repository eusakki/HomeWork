using System;
using System.Text;

namespace CharMatrix;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8; // Це для того, щоб консоль мала змогу бачити Українські букви
        char[,] myMatrix = {
            { 'а', 'б', 'в' },
            { 'г', 'е', 'д' },
            { 'є', 'ж', 'і' }
        };

        CharMatrix matrix = new CharMatrix(myMatrix);

        Console.WriteLine("Матриця:");
        matrix.PrintMatrix();

        Console.WriteLine("\nГоловна діагональ: " + matrix[0]);
        Console.WriteLine("Побічна діагональ: " + matrix[1]);

        Console.WriteLine($"\nКількість голосних у масиві: {matrix.VowelCount}");
    }
}