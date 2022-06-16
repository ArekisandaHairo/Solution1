using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace WindowSoul
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            FileSource fileSource = new FileSource();
            fileSource.FileWork();
            // Авторизация
            // Thread.Sleep(5000);
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
                
                var windows = new List<View>();
                Title = "Hairo";
                int c=0,c1=0;
                var anketa = new Window(10, 1, 30, 20, "Анкета", true);
                anketa.AddTexts("Список возможностей", 2, 1);
                anketa.AddButtons("Посмотреть встречи", 2, 3, () =>
                {
                    var listsp = new Window(30, 2, 30, 20, "Встречи", true);
                    listsp.AddTexts("Списки ваших встреч:", 1,0);
                    var ls = fileSource.ImporterSchedule();
                    for (var index = 0; index < ls.Count; index++)
                    {
                        listsp.AddTexts($"{++c1} {ls[index]}", 2, 2 + c);
                        c += 2;
                    }
                    listsp.Draw();
                    ReadKey();
                    c = 0;
                    c1 = 0;
                    Console.Clear();
                });
                anketa.AddButtons("Добавить встречу", 2, 5, () =>
                {
                    string text="", texttime="";
                    Drower.DrawBord(WindowWidth/2-5,WindowHeight/2-5,30,10);
                    SetCursorPosition(WindowWidth/2-4, WindowHeight/2-4);
                    Console.Write("Введите дату.");
                    SetCursorPosition(WindowWidth/2-3, WindowHeight/2-3);
                    text = ReadLine();
                    SetCursorPosition(WindowWidth/2-4, WindowHeight/2-2);
                    Write("Введите время.");
                    SetCursorPosition(WindowWidth/2-3, WindowHeight/2-1);
                    texttime = ReadLine();
                    // listsp.AddTexts($"{c1} {text} в {texttime}",2,2+c);
                    // c += 2;
                    fileSource.ExporterSchedule(0,0,text,texttime);
                });
                anketa.AddButtons("Удалить встречу", 2, 7, () => {
                    var listsp = new Window(50, 2, 30, 20, "Встречи", true);
                    listsp.AddTexts("Списки ваших встреч:", 1,0);
                    var ls = fileSource.ImporterSchedule();
                    for (var index = 0; index < ls.Count; index++)
                    {
                        c1++;
                        listsp.AddTexts($"{c1} {ls[index]}", 2, 2 + c);
                        c += 2;
                    }

                    c1 = 0;
                    c = 0;
                    listsp.Draw();
                    Drower.DrawBord(WindowWidth/2+15,WindowHeight/2-5,30,10);
                    SetCursorPosition(WindowWidth/2+17, WindowHeight/2-4);
                    Write("Введите номер встречи.");
                    SetCursorPosition(WindowWidth/2+16, WindowHeight/2-3);
                    var input = ReadLine();
                    fileSource.DeleteSchedule(Convert.ToInt32(input));
                });
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
                Window registration = new Window(10, 1, 25, 20, "Регистрация", true);
                registration.AddTexts("Ваша почта", 1,1);
                registration.AddTexts("Ваш телефон", 1,3);
                registration.AddTexts("Введите пароль", 1,5);
                registration.AddTexts("Повторите пароль", 1,7);
                registration.AddTextInputting("mail",2,2);
                registration.AddTextInputting("phone",2,4);
                registration.AddTextInputting("pass", 2, 6);
                registration.AddTextInputting("pass", 2, 8);
                registration.AddButtons("Сохранить", 3, 9, () =>
                {
                    
                } );
                windows1.Add(registration);
                // Кнопка сохранения данных+входа
            }


            List<string> GetAllSheduleByUsers(string user_id)
            {
                return null;
            }

            List<string> GetSheduleForDay(string User_ID, string Date)
            {
                GetAllSheduleByUsers(User_ID);
                return null;
            }
            /*
             * Сделать перебор кнопок
             *  сделать текстинпут основываясь на старых данных
             *  Реализовать нажатие кнопки (_ [} X)
             *  Password, mail, phone, text - тип текстов ( Text )
             *users.txt  -> ( id, mail, password(hash), FIO )
             *shedule.txt -> ( id, user_id, date )
             *pacient.txt -> ( id, FIO, time, time )
             *
             * Поиск записей по дате
             * List<string> GetAllSheduleByUsers(User_ID);
             * List<string> GetSheduleForDay(User_ID, Date){ GetAll... }
            */
        }
    }
}