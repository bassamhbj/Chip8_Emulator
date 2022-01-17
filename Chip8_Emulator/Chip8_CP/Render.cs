using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chip8_CP
{
    public class Render
    {
        private const int _columns = 64;
        private const int _rows = 32;

        public int[,] Display { get; private set; }

        public Render()
        {
            Clear();
        }

        public bool SetPixel(int x, int y)
        {
            if(x > _rows) {
                while (x > _rows) {
                    x -= _rows;
                }
            } else if(x < 0) {
                while (x < _rows) {
                    x += _rows;
                }
            }

            if (y > _columns) {
                while (y > _columns) {
                    y -= _columns;
                }
            }
            else if (y < 0) {
                while (y < _columns) {
                    y += _columns;
                }
            }

            Display[x, y] ^= 1;

            return Display[x, y] == 0; // return true if value is 0. It means a pixel must be erased
        }

        public void Clear()
        {
            Display = new int[_rows, _columns];
        }

        public void RenderDisplay()
        {
            Console.Clear();

            for(int x = 0; x < _rows; x++) {
                string rowToPrint = "";

                for(int y = 0; y < _columns; y++) {
                    if(Display[x, y] == 1) {
                        rowToPrint += "■";
                    }

                    rowToPrint += Display[x, y] == 1 ? "■" : "  ";
                }

                Console.WriteLine(rowToPrint);
            }
        }

    }
}
