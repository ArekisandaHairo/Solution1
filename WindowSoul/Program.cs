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
            Window _window = new Window(0, 0, 40, 20, "Sing in / Sing up",
                true);
            windows.Add(_window);
            CursorVisible = false;
            windows[0].AddButtons(new Buttons(_window.PosX, _window.PosY, _window.Weiht, _window.Height, "Войти"));
            windows[0].AddButtons(new Buttons(_window.PosX, _window.PosY, _window.Weiht, _window.Height,
                "Зарегистрироваться"));
            windows[0].AddTexts(new Text(_window.PosX, _window.PosY, _window.Weiht, _window.Height,
                "Приветствую юзер, пожалуйста, пройдите регистрацию, что бы войти в систему."));
            windows[0].SetPosElem(2, 0, 0);
            // закинуть делегата в кнопку
            windows[0].AddDelegate(Signin, 1);
            windows[0].AddDelegate(Registration, 2);
            // поместить кнопку в указанную позицию
            windows[0].SetPosElem(0, 3, 3);
            windows[0].SetPosElem(1, 3, 6);
            // SetCursorPosition(3, 5);
            // Write("Приветствую, пожалуйста войдите в систему или зарегестрируйтесь.");
            Work work1 = new Work(windows, 0);
            work1.PrintWin();
            work1.KeysActivity();


            Console.Title = "Hairo";
            windows.Add(new Window(0, 0, 10, 10, "Okno0", true));
            windows.Add(new Window(20, 10, 40, 15, "Okno1", true));
            windows.Add(new Window(30, 5, 50, 20, "Okno2", true));
            Work work = new Work(windows, 0);
            work.PrintWin();
            work.KeysActivity();
            Work.Exit();


            void Signin()
            {
                windows.Add(new Window(10, 10, 30, 20, "Вход", true));
                windows[1].AddTextInputting(new TextInput(windows[1].PosX, windows[1].PosY, windows[1].Weiht, windows[1].Height));
                windows[1].AddTextInputting(new TextInput(windows[1].PosX, windows[1].PosY, windows[1].Weiht, windows[1].Height));
                windows[1].AddTexts(new Text(windows[1].PosX, windows[1].PosY, windows[1].Weiht, windows[1].Height,
                    "Введите почту и пароль"));
                
                windows[1].SetPosElem(0, 3, 3);
                windows[1].SetPosElem(1, 3, 6);
                windows[1].SetPosElem(2, 2, 1);
                

            }

            void Registration()
            {
                windows.Add(new Window(10, 10, 25, 20, "Регистрация", true));
                // Поле ввода почты
                // Поле ввода номера телефона
                // Поле ввода пароля
                // Поле ввода повторного пароля
                // Кнопка сохранения данных+входа
                // Кнопка Рестарта
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