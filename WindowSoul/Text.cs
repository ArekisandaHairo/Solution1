using System;

namespace WindowSoul
{
    public class Text : View
    {
        private string _text;
        private int _x, _y;
        public Text(int posX, int posY, int weight, int height, string text) : base(posX, posY, weight, height)
        {
            SetPos(_x,_y);
            _text = text;
        }


        internal override void Put_in_place(int x, int y)
        {
            _x = x;
            _y = y;
        }
        internal override void Draw()
        {
            if (_text != null)
            {
                Insert_LF_n(PosX, PosY, _text, Weight - 1, Height);
            }
        }

        

        private void Insert_LF_n(int x, int y, string s, int width, int height)
        {
            int index = 0;
            int count = 0;
            for (int i = y; i < y + height; i++)
            {
                SetPos(_x,_y+count);
                count++;
                for (int j = x+_x; j < x + width; j++)
                {
                    if (index < s.Length) Console.Write(s[index++]);
                    else break;
                }
            }
        }
    }
}