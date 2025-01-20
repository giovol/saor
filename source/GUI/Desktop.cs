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
        public static bool Pressed;
        public static List<App> appList = new();
        public static Color accentColor = Color.Black;
        static Dock dock = new();
        public static void BeforeRun()
        {
            Canvas = Display.GetDisplay(1280, 720);
            Canvas.Update();
            defaultAppLogo = Resources.Program;
            MouseManager.ScreenWidth = Canvas.Width;
            MouseManager.ScreenHeight = Canvas.Height;
            MouseManager.X = (uint)Canvas.Width / 2;
            MouseManager.Y = (uint)Canvas.Height / 2;
            appList.Add(new Clock(200,200,100,100));    
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
            if(Canvas.Width == 1280 & Canvas.Height == 720)
            {
                Canvas.DrawImage(0, 0, Resources.Background, false);
            }
            foreach (App app in appList)
            {
                app.Update();
            }
            dock.Update();

            Canvas.DrawImage((int)MouseManager.X, (int)MouseManager.Y, Resources.Mouse);

            Canvas.Update();
        }
    }
}
