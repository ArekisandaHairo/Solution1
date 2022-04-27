using System;

namespace WindowSoul
{
    public class Text : Counteiner
    {
        public Text(int posX, int posY, int weiht, int height, string text) : base(posX, posY, weiht, height)
        {
            this.text = text;
        }


        public void TextI(int x, int y, int w, int h)
        {
            if (text != null)
            {
                Insert_LF_n(x, y, text, w - 1, h);
            }
        }


        private void Insert_LF_n(int x, int y, string s, int width, int height)
        {
            int index = 0;
            for (int i = y; i < y + height; i++)
            {
                Console.SetCursorPosition(x+1,y+3);
                for (int j = x; j < x + width; j++)
                {
                    if (index < s.Length) Console.Write(s[index++]);
                    else break;
                }
            }
        }
    }
}