using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.System;
using PrismAPI.Graphics;
using PrismAPI.Hardware.GPU;
using saor.Core;

namespace saor.GUI
{
    public class Desktop
    {
        public static Display Canvas;
        public static Canvas defaultAppLogo;
        public static Canvas bootLogo;
        public static Canvas Background;
        public static Canvas Mouse;
        public static bool Pressed;
        public static List<App> appList = new();
        public static Color accentColor;
        public static void BeforeRun()
        {
            Mouse = Resources.Mouse;
            bootLogo = new Canvas(1280, 720);
            Canvas = Display.GetDisplay(1280, 720);
            Canvas.Update();
            Background = new Canvas(1280, 720);
            defaultAppLogo = new Canvas(128, 128);
            MouseManager.ScreenWidth = Canvas.Width;
            MouseManager.ScreenHeight = Canvas.Height;
            MouseManager.X = (uint)Canvas.Width / 2;
            MouseManager.Y = (uint)Canvas.Height / 2;
        }
        public static void Run()
        {
            switch (MouseManager.MouseState)
            {
                case MouseState.Left:
                    Pressed = true;
                    break;
                case MouseState.None:
                    Pressed = false;
                    break;
            }
            Canvas.Clear();
            Canvas.DrawImage(0,0,Background,false);
            foreach (App app in appList)
            {
                app.Update();
            }
            dock.Update();

            Canvas.DrawImage((int)MouseManager.X, (int)MouseManager.Y, Mouse);

            Canvas.Update();
        }
    }
}
