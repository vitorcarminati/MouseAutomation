using WindowsInput;

namespace MouseAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            int delayMilliseconds = 1000;

            int x = 500;
            int y = 300;

            var simulator = new InputSimulator();

            while (true)
            {
                try
                {
                    MoveMouseTo(simulator, x, y);

                    ClickMouse(simulator);

                    Console.WriteLine($"Clique simulado em: X={x}, Y={y}");

                    Thread.Sleep(delayMilliseconds);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                }
            }
        }

        static void MoveMouseTo(InputSimulator simulator, int x, int y)
        {
            simulator.Mouse.MoveMouseTo((x * 65535) / 1920, (y * 65535) / 1080);
        }

        static void ClickMouse(InputSimulator simulator)
        {
            simulator.Mouse.LeftButtonClick();
            Thread.Sleep(100);
        }
    }
}