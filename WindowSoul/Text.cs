using System;

namespace WindowSoul
{
    public class Text : View
    {
        internal string text;
        public Text(int posX, int posY, int weiht, int height, string text) : base(posX, posY, weiht, height)
        {
            this.text = text;
        }


        internal override void Draw()
        {
            if (text != null)
            {
                Insert_LF_n(PosX, PosY, text, Weiht - 1, Height);
            }
        }

        internal override ref string str()
        {
            return ref text;
        }

        private void Insert_LF_n(int x, int y, string s, int width, int height)
        {
            int index = 0;
            for (int i = y; i < y + height; i++)
            {
                Console.SetCursorPosition(x+1,i+3);
                for (int j = x; j < x + width; j++)
                {
                    if (index < s.Length) Console.Write(s[index++]);
                    else break;
                }
            }
        }
    }
}