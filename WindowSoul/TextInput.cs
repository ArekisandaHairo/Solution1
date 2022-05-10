using System;
using System.Collections.Generic;

namespace WindowSoul
{
    public class TextInput : View
    {
        private List<int> pasword;
        private int _x, _y;
        public TextInput(int posX, int posY, int weiht, int height) : base(posX, posY, weiht, height)
        {
           
        }
        public override void Put_in_place(int x, int y)
        {
            _x = x;
            _y = y;
        }

        internal override void SelectInp(string str)
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
            while (s.KeyChar != 13)
            {
                s = Console.ReadKey();
                Console.Write("*");
                pasword.Add(s.KeyChar);
            }
        }
        internal bool Mail()
        {
            string str = Console.ReadLine();
            int fl = 0;
            bool c = false;
            foreach (var b in str)
            {
                if (b == '@' || b == '.')
                {
                    fl++;
                }
            }
            if (fl >= 2)
            {
                c = true;
            }

            return c;
        }
        internal void Pisanina()
        {
            
        }
        internal bool Phone()
        {
            bool c = false;

            return c;
        }
    }
}