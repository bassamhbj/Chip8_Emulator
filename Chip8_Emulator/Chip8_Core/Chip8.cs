using System.Threading;
using System.Threading.Tasks;

namespace Core
{
    public class Chip8
    {
        private IRenderListener _renderListener;
        private IKeyboardListener _keyboardListener;

        private const int FPS = 60;
        private const int FPS_INTERVAL = 1000 / FPS;

        public Chip8(IRenderListener renderListener, IKeyboardListener keyboardListener)
        {
            _renderListener = renderListener;
            _keyboardListener = keyboardListener;
        }

        public async Task DoRenderDisplay(CancellationToken token)
        {
            while (true) {
                _renderListener.RenderDisplay();

                await Task.Delay(FPS_INTERVAL);

                if (token.IsCancellationRequested) {
                    break;   
                }
            }
        }

        public async Task DoReadInput(CancellationToken token)
        {
            while (true) {
                _keyboardListener.InputKey();

                await Task.Delay(FPS_INTERVAL);

                if (token.IsCancellationRequested) {
                    break;
                }
            }
        }
    }
}
