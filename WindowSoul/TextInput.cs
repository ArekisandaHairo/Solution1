using System;

namespace WindowSoul
{
    public class TextInput : View
    {
        // private string returnsChars;
        private int _x, _y;
        internal ButtonVoid _buttonVoid;
        private string _type;
        private string textvisibility;
        private string textsave;
        public TextInput(int posX, int posY, int weight, int height) : base(posX, posY, weight, height)
        {
            _buttonVoid = () => Inject();
            textvisibility = "_______________";
        }

        public override void SetType(string stri)
        {
            _type = stri;
        }
        internal override void UseMethod()
        {
            _buttonVoid();
        }

        // private void Shearing(ConsoleKeyInfo consoleKey, ref string sheartext)
        // {
        //     Console.Write(consoleKey.Key.ToString().ToLower());
        //     textsave += consoleKey.Key.ToString().ToLower();
        // }

        private void Inject()
        {
            textsave = "";
            // ConsoleKeyInfo consoleKeyInfo = new ConsoleKeyInfo();
            SetPos(_x,_y);
            // int cou = 0;
            textsave = Console.ReadLine();
            // while (consoleKeyInfo.Key != ConsoleKey.Enter)
            // {
            //     consoleKeyInfo = Console.ReadKey(true);
            //     if ((consoleKeyInfo.KeyChar >= 47 && consoleKeyInfo.KeyChar <= 91) || consoleKeyInfo.KeyChar == 32)
            //     {
            //         cou++;
            //         Shearing(consoleKeyInfo, ref textsave);
            //     }
            //     if (consoleKeyInfo.Key == ConsoleKey.Backspace)
            //     {
            //         SetPos(_x+cou-1,_y);
            //         textsave.Remove(cou-1);
            //         Console.Write(" ");
            //         SetPos(_x+cou-1,_y);
            //         if (cou > 1) cou -= 1;
            //     }
            // }

            if (_type == "text")
            {
                textvisibility = "";
                textvisibility = textsave;
            }
            if (_type == "mail" && Mail())
            {
                textvisibility = "";
                textvisibility = textsave;
            }
            if (_type == "pass")
            {
                Password();
                textvisibility = "";
                textvisibility = textsave;
            }
            if (_type == "phone" && Phone())
            {
                textvisibility = "";
                textvisibility = textsave;
            }
            
        }
        internal override void Draw()
        {
            SetPos(_x,_y);
            Console.Write(textvisibility);
        }
        internal override void Put_in_place(int x, int y)
        {
            _x = x;
            _y = y;
        }

        private void Password()
        {
            string s ="";                
            SetPos(_x,_y);
            for (int i = 0; i < textsave.Length; i++)
            {
                s+="*";
            }

            textsave = s;
        }
        internal bool Mail()
        {
            int rule = 0;
            foreach (var s in textsave)
            {
                if (s == '@' || s == '.')
                {
                    rule++;
                }
            }

            if (rule == 2)
            {
                return true;
            }

            return false;
        }
        private bool Phone()
        {
            int i=0;
            foreach (char VARIABLE in textsave)
            {
                try
                {
                    i += Convert.ToInt32(VARIABLE);
                }
                catch (Exception e)
                {
                    SetPos(_x-6,_y);
                    Console.WriteLine("Error");
                    throw;
                }
            }

            return false;
        }
    }
}