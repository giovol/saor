using Cosmos.System;
using PrismAPI.Graphics;
using Resources = saor.Core.Resources;

namespace saor.GUI.DE
{
    public static class MouseDriver
    {
        public static Canvas Mouse = Resources.Mouse;
        public static int LastMouseX = (int)MouseManager.X, LastMouseY = (int)MouseManager.Y, MouseOffsetX = 0, MouseOffsetY = 0;

        public static void Initialize()
        {
            MouseManager.ScreenWidth = WindowManager.Screen.Width;
            MouseManager.ScreenHeight = WindowManager.Screen.Height;
        }

        public static void Update()
        {
            WindowManager.Screen.DrawImage((int)MouseManager.X - MouseOffsetX, (int)MouseManager.Y - MouseOffsetY, Mouse, true);
        }
    }
}