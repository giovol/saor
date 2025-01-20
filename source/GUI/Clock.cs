using System;
using Cosmos.System;
using PrismAPI.Graphics.Rasterizer;
using saor.GUI;
using System.Xml.Linq;
using PrismAPI.Graphics;

namespace saor.GUI
{
    class Clock : App
    {
        public Clock(ushort width, ushort height, int x = 0, int y = 0) : base(width, height, x, y)
        {
            name = "Clock";
        }

        public override void _Update()
        {
            drawHand(Desktop.Canvas, Color.Black, (x + width / 2), (y + height / 2), DateTime.Now.Hour, 40);
            drawHand(Desktop.Canvas, Color.Black, (x + width / 2), (y + height / 2), DateTime.Now.Minute, 60);
            drawHand(Desktop.Canvas, Color.Red, (x + width / 2), (y + height / 2), DateTime.Now.Second, 80);
        }

        void drawHand(Canvas canvas, Color color, int xStart, int yStart, int angle, int radius)
        {
            int[] sine = new int[16] { 0, 27, 54, 79, 104, 128, 150, 171, 190, 201, 221, 233, 243, 250, 254, 255 };
            int xEnd, yEnd, quadrant, x_flip, y_flip;

            quadrant = angle / 15;

            switch (quadrant)
            {
                case 0: x_flip = 1; y_flip = -1; break;
                case 1: angle = Math.Abs(angle - 30); x_flip = y_flip = 1; break;
                case 2: angle = angle - 30; x_flip = -1; y_flip = 1; break;
                case 3: angle = Math.Abs(angle - 60); x_flip = y_flip = -1; break;
                default: x_flip = y_flip = 1; break;
            }

            xEnd = xStart;
            yEnd = yStart;

            if (angle > sine.Length) return;

            xEnd += (x_flip * ((sine[angle] * radius) >> 8));
            yEnd += (y_flip * ((sine[15 - angle] * radius) >> 8));
            canvas.DrawLine(xStart, yStart, xEnd, yEnd, color);
        }
    }
}