using System;

namespace WindowSoul
{
    
    
    public class Buttons : View
    {
        private readonly string _text;
        private int _x, _y;
        internal ButtonVoid Degi;
        public string Tag;
        public Buttons(int posX, int posY, int weight, int height, string t) : base(posX, posY, weight, height)
        {
            _text = t;
        }

        internal override void UseMethod() => Degi(); 
        internal override string GetInfoT() => _text;

        internal override void Put_in_place(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public override void SetTag(string tag)
        {
            Tag = tag;
        }
        
        internal override string GetTag() => Tag;
        internal override void Draw()
        {
            SetPos(_x,_y);
            Console.Write(_text);
        }


        internal override void Deg( ButtonVoid buttonVoid) => Degi = buttonVoid;
    }
}