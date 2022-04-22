using System;

namespace WindowSoul
{
    public class Text : View
    {
        private string _text;
        public Text(int posX, int posY, int weiht, int height, string text) : base(posX, posY, weiht, height)
        {
            _text = text;
        }

        public void TextInput()
        {
            if (_text == "")
            {
                Console.SetCursorPosition(PosX+1, PosY+3);
                _text = Console.ReadLine();
            }
        }
        public void TextI()
        {
            if (_text.Length >= Weiht)
            {
                Insert_LF_n(PosX, PosY, _text, Weiht - 1, Height);
            }
            else
            {
                Console.SetCursorPosition(PosX + 1, PosY + 3);
                Console.Write(_text);
            }
        }


        private static void Insert_LF_n(int x, int y, string s, int width, int height)
        {
            int index = 0;
            for (int i = y; i < y + height; i++)
            {
                Console.SetCursorPosition(x + 1, 3 + i);
                for (int j = x; j < x + width; j++)
                {
                    if (index < s.Length)
                    {
                        Console.Write(s[index]);
                        index++;
                    }
                    else break;
                }
            }
        }
    }
}