using System;
using static System.Console;
using System.Collections.Generic;
using System.Threading;

namespace WindowSoul
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Авторизация
            List<View> windows1 = new List<View>();
            Window _window = new Window(0, 0, 40, 20, "Sing in / Sing up",
                true);
            CursorVisible = true;
            _window.AddTexts("Приветствую юзер, пожалуйста, пройдите регистрацию, что бы войти в систему.", 0, 0);
            _window.AddButtons("Войти", 3, 3, Signin);
            _window.AddButtons("Зарегистрироваться", 3, 6,Registration);
            windows1.Add(_window);
            Work work1 = new Work(windows1, 0);
            work1.PrintWin();
            work1.KeysActivity();
            // work1.RemoveWins();



            void WorkTable()
            {
                // Thread.Sleep(100);
                // 
                // Thread.Sleep(100);
                List<View> windows = new List<View>();
                Console.Title = "Hairo";
                Window anketa = new Window(10, 10, 30, 20, "Анкета", true);
                anketa.AddTexts("Список возможностей", 2, 1);
                windows.Add(anketa);
                Work work = new Work(windows, 0);
                work.PrintWin();
                work.KeysActivity();
                Work.Exit();
            }


            void Signin()
            {
                Window singWindow = new Window(10, 10, 30, 20, "Вход", true);
                singWindow.AddTexts("Введите почту и пароль", 2, 1);
                singWindow.AddTextInputting( "mail", 3, 3);
                singWindow.AddTextInputting("pass", 3, 5);
                singWindow.AddButtons("Войти", 3, 7, WorkTable);

                windows1.Add(singWindow);
            }

            void Registration()
            {
                windows1.Add(new Window(10, 10, 25, 20, "Регистрация", true));
                // Поле ввода почты
                // Поле ввода номера телефона
                // Поле ввода пароля
                // Поле ввода повторного пароля
                // Кнопка сохранения данных+входа
                // Кнопка Рестарта
            }


            /*
             * Сделать перебор кнопок
             *  сделать текстинпут основываясь на старых данных
             *  Реализовать нажатие кнопки (_ [} X)
             *  Password, mail, phone, text - тип текстов ( Text )
             *users.txt  -> ( id, mail, password(hash), FIO )
             *shedule.txt -> ( id, user_id, pacient_id, date )
             *pacient.txt -> ( id, FIO, time, time )
            */
        }
    }
}