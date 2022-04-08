using System;

namespace KleninShiza
{
    public class TextInput : View
    {
        private string _textinputting;
        private string _password; // ***
        private string _mail; // ___@__.__
        private string _phone; // +_(___)-___-__-__


        public TextInput(int posX, int posY, int weiht, int height) : base(posX, posY, weiht, height)
        {
        }
    }

}