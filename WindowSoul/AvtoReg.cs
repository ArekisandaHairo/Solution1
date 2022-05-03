using System;
using System.Collections.Generic;
using static System.Console;

namespace WindowSoul
{
    public class AvtoReg : View
    {
        private Window _window;
        public AvtoReg(int x, int y, int w, int h) : base(x,y,w,h)
        {
            _window = new Window(x,y,w,h,"Registration", true);
        }

        public void draw()
        {
            _window.Draw();
        }

        private void Signin()
        {
            _window.Draw();
            SetPos(30,4);
            Write("Вход");
            while (ReadKey().KeyChar != 27)
            {
                Text_Input textInput1 = new Text_Input(_window.PosX,_window.PosY,_window.Weiht,_window.Height);
                
                SetPos(10,10);
                textInput1.Password();
            }
        }

        private void Registration()
        {
            _window.Draw();
            SetPos(30,4);
            Write("Регистрация");
            
            // while (true)
            // {
                
            // }
        }

        public void Rabota()
        {
            CursorVisible = false;
            List<ButtonsWin> btns = new List<ButtonsWin>();
            btns.Add(new ButtonsWin(_window.PosX,_window.PosY,_window.Weiht,_window.Height, "Войти"));
            btns.Add(new ButtonsWin(_window.PosX,_window.PosY,_window.Weiht,_window.Height, "Зарегистрироваться"));
            SetPos(30,4);
            Write("Приветствую, пожалуйста войдите в систему или зарегестрируйтесь.");

            btns[0].CreateBttn(30,8);
            btns[1].CreateBttn(30,12);
            
            ConsoleKeyInfo consoleKeyInfo = new ConsoleKeyInfo();
            ReadKey(true);
            while (consoleKeyInfo.Key != ConsoleKey.Escape)
            {
                consoleKeyInfo = ReadKey();
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.UpArrow :
                        btns[0].EnableBtn();
                        btns[1].PrintButton();
                        consoleKeyInfo = ReadKey();
                        if (consoleKeyInfo.Key == ConsoleKey.Enter) Signin();
                            break;
                    case ConsoleKey.DownArrow :
                        btns[1].EnableBtn();
                        btns[0].PrintButton();
                        consoleKeyInfo = ReadKey();
                        if (consoleKeyInfo.Key == ConsoleKey.Enter) Registration();
                        break;
                }
            }

            void PrintAllBtn()
            {
                foreach (var btn in btns)
                {
                    btn.PrintButton();
                }
            }


        }
        
    }
}