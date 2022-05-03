using System;
using System.Collections.Generic;

namespace WindowSoul
{
    public class Text_Input : View
    {
        private List<int> pasword;
        public Text_Input(int posX, int posY, int weiht, int height) : base(posX, posY, weiht, height)
        {
           
        }

        internal override string Input()
        {
            string text = Console.ReadLine();
            return text;
        }

        internal void Password()
        {
            ConsoleKeyInfo s = new ConsoleKeyInfo();
            while (s.KeyChar !=13)
            {
                s = Console.ReadKey();
                Console.Write("*");
                pasword.Add(s.KeyChar);
            }
        }
        internal void Mail()
        {
            
        }
        internal void Pisanina()
        {
            
        }
        internal void Phone()
        {
            
        }
    }
}