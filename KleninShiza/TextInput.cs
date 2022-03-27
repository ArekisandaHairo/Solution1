using System;

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
            Console.Write(_text);
        }
    }
}