using System;
using static System.Console;
using System.Collections.Generic;

namespace WindowSoul
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Авторизация
            List<View> windows = new List<View>();
            Rabota();
            ReadKey();

            Console.Title = "Hairo";
            windows.Add(new Window(0, 0, 10, 10, "Okno0", true));
            windows.Add(new Window(20, 10, 40, 15, "Okno1", true));
            windows.Add(new Window(30, 5, 50, 20, "Okno2", true));
            Work work = new Work(windows, 0);
            work.PrintWin();
            work.KeysActivity();
            Work.Exit();


            void Rabota()
            {
                Window _window = new Window(0, 0, Console.WindowWidth - 1, Console.WindowHeight - 1, "Registration",
                    true);
                _window.Draw();
                CursorVisible = false;
                List<Buttons> btns = new List<Buttons>();
                btns.Add(new Buttons(_window.PosX, _window.PosY, _window.Weiht, _window.Height, "Войти"));
                btns.Add(new Buttons(_window.PosX, _window.PosY, _window.Weiht, _window.Height, "Зарегистрироваться"));
                SetCursorPosition(3, 5);
                Write("Приветствую, пожалуйста войдите в систему или зарегестрируйтесь.");

                btns[0].CreateBttn(30, 8);
                btns[1].CreateBttn(30, 12);

                ConsoleKeyInfo consoleKeyInfo = new ConsoleKeyInfo();
                ReadKey(true);
                while (consoleKeyInfo.Key != ConsoleKey.Escape)
                {
                    consoleKeyInfo = ReadKey();
                    switch (consoleKeyInfo.Key)
                    {
                        case ConsoleKey.UpArrow:
                            btns[0].EnableBtn();
                            btns[1].PrintButton();
                            if (ReadKey().Key == ConsoleKey.Enter) Signin();
                            break;
                        case ConsoleKey.DownArrow:
                            btns[1].EnableBtn();
                            btns[0].PrintButton();
                            consoleKeyInfo = ReadKey();
                            if (ReadKey().Key == ConsoleKey.Enter) Registration();
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

                void Signin()
                {
                    _window.Draw();
                    Console.SetCursorPosition(30, 4);
                    Write("Вход");
                    Text_Input textInput1 = new Text_Input(_window.PosX, _window.PosY, _window.Weiht, _window.Height);
                    SetCursorPosition(10, 10);
                    textInput1.Password();
                }

                void Registration()
                {
                    _window.Draw();
                    SetCursorPosition(30, 4);
                    Write("Регистрация");

                    // while (true)
                    // {

                    // }
                }
            }


            /*
             * Сделать перебор кнопок
             *  Реализовать нажатие кнопки (_ [} X)
             *  Password, mail, phone, text - тип текстов ( Text )
             *users.txt  -> ( id, mail, password(hash), FIO )
             *shedule.txt -> ( id, user_id, pacient_id, date )
             *pacient.txt -> ( id, FIO, time, time )
            */
        }
    }
}