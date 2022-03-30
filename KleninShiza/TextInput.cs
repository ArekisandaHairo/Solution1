using System;
using System.Xml.Schema;

namespace KleninShiza
{
    public class TextInput : View
    {
        private string _text;

        public TextInput(int posX, int posY, int weiht, int height , string text) : base(posX, posY, weiht, height)
        {
            _text = text;
        }

        public void TextInputting()
        {
            Console.SetCursorPosition(_posX+1,_posY+3);
            
            if (_text.Length > _weiht)
            {
                Insert_LF_n(_posX, _posY,_text, _weiht-1, _height);
            }
            else
            {
                Console.Write(_text);
            }
        }
        private static void Insert_LF_n(int x , int y, string s, int width, int height)
        {
            int index = 0;
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(x+1,y+3+i);
                for (int j = 0; j < width; j++)
                {
                    if (index < s.Length)
                    {
                        Console.Write(s[index]);
                        index++;
                    } else break;
                }    
            }
        }
    }
    
}