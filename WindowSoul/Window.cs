using System;

namespace WindowSoul
{
    public class Window : Counteiner
    {
        private bool _off;
        private readonly Header _header;
        private readonly Text _txt;

        public Window(int posX, int posY, int weiht, int height, string title, bool off) : base(posX, posY, weiht,
            height)
        {
            _txt = new Text(posX, posY, weiht, height, "");
            _header = new Header(title, posX, posY, weiht, height);
            _off = off;
        }

        public void Draw()
        {
            if (_off)
            {
                Drower.DrawBord(PosX, PosY, Weiht, Height);
                Drower.Cler(PosX, PosY, Weiht, Height);
                _txt.TextI();
                _header.Draw();
            }
        }

        public override void DrawText()
        {
            _txt.TextInput();
        }

        public override void Move(int x, int y)
        {
            if (x >= 0 && y >= 0 && x + Weiht < Console.WindowWidth && y + Height < Console.WindowHeight)
            {
                PosX = x;
                PosY = y;
                _header.Move(x, y);
            }
        }

        public override void Change(int x, int y)
        {
            if (x >= 10 && y >= 10 && x < Console.WindowWidth && y < Console.WindowHeight)
            {
                Weiht = x;
                Height = y;
                _header.Change(x, y);
            }
        }

        public override void Collapse(ref bool c)
        {
            if (c)
            {
                _off = false;
                c = false;
            }
            else
            {
                _off = true;
                c = true;
            }
        }
    }
}