using System.Threading;

using SecretLabs.NETMF.Hardware.Netduino;
using MicroToolskit.Hardware.Displays.TFTColor;

namespace Netduino
{
    public class Program
    {
        public static void Main()
        {
            ST7735 DisplayShield = new ST7735(Pins.GPIO_PIN_D8, Pins.GPIO_PIN_D10, SPI_Devices.SPI1);
            int i = 0;

            // Rectangle
            DisplayShield.DrawFilledRectangle(0, 0, 160, 128, Color.Black);
            Thread.Sleep(1000);

            DisplayShield.DrawLargeText(20, 30, ".NEMF v4.3", Color.Green);

            while (true)
            {
                DisplayShield.DrawText(30, 60, "Count: " + i++, Color.Magenta);
                Thread.Sleep(10);
            }
        }
    }
}
