using System;
using System.Collections.Generic;

namespace WindowSoul
{
    public class Text_Input : View
    {
        public Text_Input(int posX, int posY, int weiht, int height) : base(posX, posY, weiht, height)
        {
           
        }

        internal override string Input()
        {
            string text = Console.ReadLine();
            return text;
        }
    }
}