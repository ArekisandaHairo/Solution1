using System;
using System.Collections.Generic;

namespace KleninShiza
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<View> windows = new List<View>();

            Console.Title = "Hairo";
            Window win1 = new Window(0, 0, 10,  10, "Okno0", true);
            Window win2 = new Window( 20, 10,40,15,"Okno1", true);
            Window win3 = new Window( 30,5,45,15,"Okno2", true);
            windows.Add(win1);
            windows.Add(win2);
            windows.Add(win3);
            Work work = new Work(windows, 0);
            //work.Swap(work._activeWin, work._list.Count-1 );
            work.PrintWin();
            int count = work._list.Count;
            int tab_count=0;
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
            while (keyInfo.Key != ConsoleKey.Escape)
            {
                keyInfo = Console.ReadKey(true);
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
                // Alt + X и мы меняем окно
                if ((keyInfo.Modifiers & ConsoleModifiers.Alt)!=0)
                {
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.X:
                            work._activeWin--;
                            work.Swap(work._activeWin, work._list.Count-1 );
                            work.PrintWin();
                            break;
                        case ConsoleKey.V:
                            count++;
                            work.AddOkno(count);
                            break;
                    }
                }

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
            * Я НЕ ПОНИМАЮ КАКА СДЕЛАТЬ ALT + TAB, ОНО ЖЕ НЕ ЗАЖИМАЕТСЯ!!!!
            */
        }
    }
}