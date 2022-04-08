using System;
using System.Collections.Generic;

namespace KleninShiza
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<View> windows = new List<View>();
            //По итогу должно остаться только эти 4 строчки, то есть от сель
            Console.Title = "Hairo";
            Window win1 = new Window(0, 0, 10,  10, "Okno0", true);
            Window win2 = new Window( 20, 10,40,15,"Okno1", true);
            Window win3 = new Window( 30,5,45,15,"Okno2", true);
            // до сель
            windows.Add(win1);
            windows.Add(win2);
            windows.Add(win3);
            Work work = new Work(windows, 0);
            work.PrintWin();
            int count = work._list.Count;
            int tab_count=0;
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
            while (keyInfo.Key != ConsoleKey.Escape)
            {
                keyInfo = Console.ReadKey(true);
                // Стандартное перемещение окна
                switch (keyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        windows[work._activeWin].Move(windows[work._activeWin]._posX+1,windows[work._activeWin]._posY);
                        work.PrintWin();
                        break;
                    case ConsoleKey.LeftArrow:
                        windows[work._activeWin].Move(windows[work._activeWin]._posX-1,windows[work._activeWin]._posY);
                        work.PrintWin();
                        break;
                    case ConsoleKey.UpArrow:
                        windows[work._activeWin].Move(windows[work._activeWin]._posX,windows[work._activeWin]._posY-1);
                        work.PrintWin();
                        break;
                    case ConsoleKey.DownArrow:
                        windows[work._activeWin].Move(windows[work._activeWin]._posX,windows[work._activeWin]._posY+1);
                        work.PrintWin();
                        break;
                } 
                
                if ((keyInfo.Modifiers & ConsoleModifiers.Alt)!=0)
                {
                    switch (keyInfo.Key)
                    {
                        // Добавить новое окно
                        case ConsoleKey.V:
                            count++;
                            work.AddOkno(count);
                            break;
                    }
                }
                // Нажатие на "Tab" меняет фокус активного окна 
                if (keyInfo.Key == ConsoleKey.Tab)
                {
                    if (tab_count < work._list.Count-1)
                    {
                        tab_count++;
                        work._activeWin = tab_count;
                        work.PrintWin();
                    }
                    else if (tab_count == work._list.Count-1)
                    {
                        tab_count = 0;
                        work._activeWin = tab_count;
                        work.PrintWin();
                    }
                    
                }
            } 
            /*
             * Реализовать нажатие кнопки
             * Сделать увеличение окна до полного экрана
             * Сделать скрытие окна ( отрисовка только хэдера )
             * Отруб окна полностью
             * Работа с шириной и высотой окна
             * 
            */
        }
    }
}