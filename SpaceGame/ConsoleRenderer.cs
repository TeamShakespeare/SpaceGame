using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceGame
{
    public class ConsoleRenderer : IRenderer
    {
        int renderContextMatrixRows;
        int renderContextMatrixCols;
        char[,] renderContextMatrix;

        public ConsoleRenderer(int visibleConsoleRows, int visibleConsoleCols)
        {
            renderContextMatrix = new char[visibleConsoleRows, visibleConsoleCols];

            this.renderContextMatrixRows = renderContextMatrix.GetLength(0);
            this.renderContextMatrixCols = renderContextMatrix.GetLength(1);

            this.ClearQueue();
        }

        public void EnqueueForRendering(IRenderable obj)
        {
            char[,] objImage = obj.GetImage();

            int imageRows = objImage.GetLength(0);
            int imageCols = objImage.GetLength(1);

            MatrixCoords objTopLeft = obj.GetTopLeft();

            int lastRow = Math.Min(objTopLeft.Row + imageRows, this.renderContextMatrixRows);
            int lastCol = Math.Min(objTopLeft.Col + imageCols, this.renderContextMatrixCols);

            for (int row = obj.GetTopLeft().Row; row < lastRow; row++)
            {
                for (int col = obj.GetTopLeft().Col; col < lastCol; col++)
                {
                    if (row >= 0 && row < renderContextMatrixRows &&
                        col >= 0 && col < renderContextMatrixCols)
                    {
                        renderContextMatrix[row, col] = objImage[row - obj.GetTopLeft().Row, col - obj.GetTopLeft().Col];
                    }
                }
            }
        }

        public void RenderAll()
        {
            Console.SetCursorPosition(0, 0);

            StringBuilder scene = new StringBuilder();

            for (int row = 0; row < this.renderContextMatrixRows; row++)
            {
                for (int col = 0; col < this.renderContextMatrixCols; col++)
                {
                    Console.SetCursorPosition(row, col);
                    //Console.BackgroundColor = ConsoleColor.White;

                    switch (renderContextMatrix[row, col])
                    {

                        case '0':
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case '1':
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case '2':
                            Console.BackgroundColor = ConsoleColor.Magenta;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case '3':
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case '4':
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case '5':
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case '6':
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        case '7':
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Black;
                            break;
                        case '8':
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case '9':
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            break;
                        //case '10:
                        //    Console.BackgroundColor = ConsoleColor.DarkGreen;
                        //    Console.ForegroundColor = ConsoleColor.DarkGreen;
                        //    break;
                        //case 11:
                        //    Console.BackgroundColor = ConsoleColor.DarkCyan;
                        //    Console.ForegroundColor = ConsoleColor.DarkCyan;
                        //    break;
                        //case 12:
                        //    Console.BackgroundColor = ConsoleColor.DarkRed;
                        //    Console.ForegroundColor = ConsoleColor.DarkRed;
                        //    break;
                        //case 13:
                        //    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        //    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        //    break;
                        //case 14:
                        //    Console.BackgroundColor = ConsoleColor.DarkGray;
                        //    Console.ForegroundColor = ConsoleColor.DarkGray;
                        //    break;
                        //case 15:
                        //    Console.BackgroundColor = ConsoleColor.DarkYellow;
                        //    Console.ForegroundColor = ConsoleColor.DarkYellow;
                        //    break;
                        default:
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                    Console.Write(renderContextMatrix[row, col]);
                }
                

            }

            Console.WriteLine();
        }

        public void ClearQueue()
        {
            for (int row = 0; row < this.renderContextMatrixRows; row++)
            {
                for (int col = 0; col < this.renderContextMatrixCols; col++)
                {
                    this.renderContextMatrix[row, col] = '0';
                }
            }
        }
    }
}
