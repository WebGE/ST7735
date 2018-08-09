using System.Threading;

using MicroToolskit.Hardware.Displays.TFTColor;
using GHI.Pins;

namespace FezPanda
{
    public class Program
    {
        public static void Main()
        {
            ST7735 DisplayShield = new ST7735(FEZPandaIII.Gpio.D8, FEZPandaIII.Gpio.D10, FEZPandaIII.SpiBus.Spi1);
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
