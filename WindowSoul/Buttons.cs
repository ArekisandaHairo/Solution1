using System;

namespace WindowSoul
{
    
    delegate void ButtonVoid();
    public class Buttons : View
    {
        public string _text;
        private bool _bttn;
        private int _x, _y;
        internal ButtonVoid _Degi;
        public Buttons(int posX, int posY, int weiht, int height, string t) : base(posX, posY, weiht, height)
        {
            _text = t;
            _bttn = false;
        }

        internal override void UseMethod() => _Degi(); 
        public override void Put_in_place(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void EnableBtn()
        {
            _bttn = true;
            Console.ForegroundColor = ConsoleColor.Green;
            SetPos(_x,_y);
            Console.Write(_text);
            Console.ResetColor();
        }

        internal override void Draw()
        {
            SetPos(_x,_y);
            Console.Write(_text);
        }


        internal override void Deg( ButtonVoid buttonVoid)
        {
            _Degi = buttonVoid;
        }
    }
}