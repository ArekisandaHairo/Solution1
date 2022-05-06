using System;

namespace WindowSoul
{
    public class Buttons : View
    {
        private string _text;
        public bool _bttn;
        private int x, y;

        public Buttons(int posX, int posY, int weiht, int height, string t) : base(posX, posY, weiht, height)
        {
            _text = t;
            _bttn = false;
        }

        public void CreateBttn(int x, int y)
        {
            this.x = x;
            this.y = y;
            SetPos(x,y);
            Console.Write(_text);
        }

        public void PrintButton()
        {
            SetPos(x,y);
            Console.Write(_text);
        }

        public void EnableBtn()
        {
            _bttn = true;
            Console.ForegroundColor = ConsoleColor.Green;
            SetPos(x,y);
            Console.Write(_text);
            Console.ResetColor();
        }
    }
}