using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.System;
using PrismAPI.Graphics;
using PrismAPI.Graphics.Fonts;

namespace saor.GUI
{
    public class App
    {
        public readonly ushort _width;
        public readonly ushort _height;
        public readonly ushort width;
        public readonly ushort height;

        public int dockX;
        public int dockY;
        public ushort dockWidth = 32;
        public ushort dockHeight = 32;

        public int _x;
        public int _y;
        public int x;
        public int y;
        public string name;
        public Canvas icon;

        bool pressed;
        public bool visible = false;

        public int _i = 0;

        public App(ushort width, ushort height, int x, int y)
        {
            _width = width;
            _height = height;
            _x = x;
            _y = y;

            this.x = x + 2;
            this.y = y + 22;
            this.width = (ushort)(width - 4);
            this.height = (ushort)(height - 23);
        }
        public void Update()
        {
            if (_i != 0)
            {
                _i--;
            }

            if (MouseManager.X > dockX && MouseManager.X < dockX + dockWidth && MouseManager.Y > dockY && MouseManager.Y < dockY + dockHeight)
            {
                Desktop.Canvas.DrawString((dockX - ((name.Length * 8) / 2) + dockWidth / 2), dockY - 20, name, Font.Fallback, Color.White);
            }

            if (MouseManager.MouseState == MouseState.Left && _i == 0)
            {
                if (MouseManager.X > dockX && MouseManager.X < dockX + dockWidth && MouseManager.Y > dockY && MouseManager.Y < dockY + dockHeight)
                {
                    visible = !visible;
                    _i = 60;
                }
            }

            if (Desktop.Pressed)
            {
                if (MouseManager.X > _x && MouseManager.X < _x + 22 && MouseManager.Y > _y && MouseManager.Y < _y + 22)
                {
                    this.pressed = true;
                }
            }
            else
            {
                this.pressed = false;
            }

            if (!visible)
                goto end;

            if (this.pressed)
            {
                this._x = (int)MouseManager.X;
                this._y = (int)MouseManager.Y;

                this.x = _x + 2;
                this.y = _y + 22;
            }

            Desktop.Canvas.DrawFilledRectangle(_x, _y, _width, _height, 0, Color.White);
            Desktop.Canvas.DrawRectangle(_x, _y, _width, _height, 0, Desktop.accentColor);
            Desktop.Canvas.DrawString(_x + 2, _y + 2, name, Font.Fallback, Color.Black);
            _Update();

        end:;
        }

        public virtual void _Update()
        {
        }
    }
}
