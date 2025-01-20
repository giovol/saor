using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.Core;
using Cosmos.System;
using PrismAPI.Graphics;

namespace saor.GUI
{
    public class Dock
    {
        ushort Width = 200;
        ushort Height = 32;
        int Devide = 20;

        public void Update()
        {
            Width = (ushort)(Desktop.appList.Count * Desktop.defaultAppLogo.Width + Desktop.appList.Count * Devide);

            Desktop.Canvas.DrawFilledRectangle(0, 0, Desktop.Canvas.Width, 20, 0, Desktop.accentColor);

            string text = "PowerOFF";
            int strX = 2;
            int strY = (20 - 16) / 2;
            Desktop.Canvas.DrawString(strX, strY, text, default, Color.White);
            if (Desktop.Pressed)
            {
                if (MouseManager.X > strX && MouseManager.X < strX + (text.Length * 8) && MouseManager.Y > strY && MouseManager.Y < strY + 16)
                {
                    ACPI.Shutdown();
                }
            }

            Desktop.Canvas.DrawFilledRectangle((Desktop.Canvas.Width - Width) / 2, Desktop.Canvas.Height - Height, Width, Height, 0, Desktop.accentColor);

            for (int i = 0; i < Desktop.appList.Count; i++)
            {
                Desktop.appList[i].dockX = (Devide / 2 + ((Desktop.Canvas.Width - Width) / 2) + (Desktop.defaultAppLogo.Width * i) + (Devide * i));
                Desktop.appList[i].dockY = Desktop.Canvas.Height - Desktop.defaultAppLogo.Height - Devide / 2;
                Desktop.Canvas.DrawImage(Desktop.appList[i].dockX, Desktop.appList[i].dockY, Desktop.defaultAppLogo, false);
            }
        }
    }
}
