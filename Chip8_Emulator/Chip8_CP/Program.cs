using Core;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Chip8_CP
{
    class Program : IKeyboardListener, IRenderListener
    {
        private bool testAnimation = true;

        private Render _render;

        static async Task Main(string[] args)
        {
            var program = new Program();

            program.Init();

            var chip8 = new Chip8(program, program);

            var cancellationToken = new CancellationTokenSource();

            var tasks = new List<Task>() {
                chip8.DoRenderDisplay(cancellationToken.Token),
                chip8.DoReadInput(cancellationToken.Token)
            };

            await Task.WhenAll(tasks);
        }

        public void Init()
        {
            _render = new Render();
        }

        public void InputKey()
        {
            var input = Console.ReadKey();

            if (input.Key == ConsoleKey.A)
                testAnimation = !testAnimation;
        }

        public void RenderDisplay()
        {
            _render.Clear();

            if (testAnimation) {
                _render.SetPixel(0, 10);
                _render.SetPixel(1, 11);
                _render.SetPixel(2, 10);
                _render.SetPixel(3, 11);
                _render.SetPixel(4, 10);
                _render.SetPixel(5, 11);
                _render.SetPixel(6, 10);
                _render.SetPixel(7, 11);
                _render.SetPixel(8, 10);
                _render.SetPixel(9, 11);
                _render.SetPixel(10, 10);
            }
            else {
                _render.SetPixel(0, 11);
                _render.SetPixel(1, 10);
                _render.SetPixel(2, 11);
                _render.SetPixel(3, 10);
                _render.SetPixel(4, 11);
                _render.SetPixel(5, 10);
                _render.SetPixel(6, 11);
                _render.SetPixel(7, 10);
                _render.SetPixel(8, 11);
                _render.SetPixel(9, 10);
                _render.SetPixel(10, 11);
            }

            _render.RenderDisplay();
        }
    }
}
