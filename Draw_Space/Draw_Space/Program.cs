using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Draw_Space
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Title = 'Space Ships by William Shakespeare';
            Console.WindowWidth = 168;
            Console.WindowHeight = 61;
            Console.BufferWidth = 185;
            Console.BufferHeight = 63;

            string element = "3";//which file to upload
            string fileName = @"converted\" + element + ".txt";
            int elementWidth = 168;
            int elementHeight = 61;
            
            int posX = 0;
            int posY = 0;
            int[,] charMatrix = new int[elementHeight,elementWidth];

            StreamReader inputMatrix = new StreamReader(fileName);

            using (inputMatrix)
            {
                string line;
                string[] matrixStrRow = new string[elementWidth];

                for (int i = posY; i < elementHeight; i++)
                {
                    line = inputMatrix.ReadLine();
                    string[] sep = new string[] { "  " };
                    matrixStrRow = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

                    for (int j = posX; j < elementWidth; j++)
                    {
                        charMatrix[i, j] = int.Parse(matrixStrRow[j]);
                    }
                }
            }

            string ac = Console.ReadLine();

            Console.SetCursorPosition(0, 0);

            for (int i = posY; i < charMatrix.GetLength(0) - 1; i++)
            {
                for (int j = posX; j < charMatrix.GetLength(1) - 1; j++)
                {
                    Console.SetCursorPosition(j, i);
                    //Console.BackgroundColor = ConsoleColor.White;

                    switch (charMatrix[i, j])
                    {

                        case 0:
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case 1:
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case 2:
                            Console.BackgroundColor = ConsoleColor.Magenta;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case 3:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 4:
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case 5:
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case 6:
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        case 7:
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Black;
                            break;
                        case 8:
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 9:
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            break;
                        case 10:
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            break;
                        case 11:
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            break;
                        case 12:
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            break;
                        case 13:
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            break;
                        case 14:
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            break;
                        case 15:
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        default:
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    } 
                    Console.Write(charMatrix[i, j]);
                }

                    Console.WriteLine();
                
            }
            Console.SetCursorPosition(0, 0);
        }
    }
}
