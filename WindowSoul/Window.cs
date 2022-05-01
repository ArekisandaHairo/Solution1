using System;

namespace WindowSoul
{
    public class Window : Conteiner
    {
        private bool _off;
        internal readonly Header _header;

        public Window(int posX, int posY, int weiht, int height, string title, bool off) : base(posX, posY, weiht,
            height)
        {
            _listelems.Add(new Text(posX, posY, weiht, height, ""));
            _listelems.Add(new Text_Input(posX, posY, weiht, height));
            _header = new Header(title, posX, posY, weiht, height);
            _off = off;
        }

        public void AddSomething(string c)
        {
            /*
             * Button - "btn"
             * Password - "pas"
             * mail - "@"
             * phone - "tel"
             */
            switch (c)
            {
                case "btn":
                    break;
                case "pas":
                    break;
                case "@":
                    break;
                case "tel":
                    break;
            }
            
        }
        public void Draw()
        {
            if (_off)
            {
                Drower.DrawBord(PosX, PosY, Weiht, Height);
                Drower.Cler(PosX, PosY, Weiht, Height);
                SetPos(0,0);
                Active(typeof(Text));
                _listelems[Active(typeof(Text))].TextI(PosX,PosY,Weiht,Height);
                _header.Draw();
            }
        }

        internal override void Inp()
        {
            SetPos(0,0);
            _listelems[Active(typeof(Text))].str() = _listelems[Active(typeof(Text_Input))].Input();
        }

        internal override void Move(int x, int y)
        {
            if (x >= 0 && y >= 0 && x + Weiht < Console.WindowWidth && y + Height < Console.WindowHeight)
            {
                PosX = x;
                PosY = y;
                _header.Move(x, y);
            }
        }

        internal override void Change(int x, int y)
        {
            if (x >= 10 && y >= 10 && x < Console.WindowWidth && y < Console.WindowHeight)
            {
                Weiht = x;
                Height = y;
                _header.Change(x, y);
            }
        }

        internal override void Collapse(ref bool c)
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