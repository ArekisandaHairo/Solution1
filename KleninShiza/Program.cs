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
            Window win1 = new Window(0, 0, Console.WindowWidth - 10, Console.WindowHeight - 10, "Okno0", true, ConsoleColor.Black);
            Window win2 = new Window( 20, 10,40,15,"Okno1", true, ConsoleColor.Black);
            Window win3 = new Window( 30,5,45,15,"Okno2", true, ConsoleColor.Black);

            windows.Add(win1);
            windows.Add(win2);
            windows.Add(win3);
            
            Work work = new Work(windows, 1);
            work.Swap(work._activeWin, work._list.Count-1 );
            work.PrintWin();
            
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
                    if (keyInfo.Key == ConsoleKey.X)
                    {
                        work._activeWin--;
                        work.Swap(work._activeWin, work._list.Count-1 );
                        work.PrintWin();
                    }
                    if (keyInfo.Key == ConsoleKey.V)
                    {
                        work.AddOkno();
                    }
                }
            }
            


/*
 // ло.
            while (true)
            {
                int index = 0;
                ConsoleKeyInfo s = Console.ReadKey();
                if (s.Key == ConsoleKey.Q)
                {
                    
                }Я пока не понимаю зачем это тут... но оно работает, точнее, работа

                if (s.Key == ConsoleKey.Q)
                {
                    
                }

                if (s.Key == ConsoleKey.Q)
                {
                    
                }

                if (s.Key == ConsoleKey.Q)
                {
                    
                }

                if (s.Key == ConsoleKey.NumPad6)
                {
                    windows[index].PeremesvhenieXUP();
                }
                if (s.Key == ConsoleKey.NumPad4)
                {
                    
                    windows[index].PeremesvhenieXDOWN();
                }
                if (s.Key == ConsoleKey.NumPad8)
                {
                    
                    windows[index].PeremesvhenieYUP();
                }
                if (s.Key == ConsoleKey.NumPad2)
                {
                    
                    windows[index].PeremesvhenieYDOWN();
                }
                
                if (s.Key == ConsoleKey.F1)
                {
                    for (int i = 0; i < windows.Count; i++)
                    {
                        if (i != 1)
                        {
                            windows[i].Draw();
                        }
                    }
                }
                if (s.Key == ConsoleKey.F2)
                {
                    for (int i = 0; i < windows.Count; i++)
                    {
                        if (i != 2)
                        {
                            windows[i].Draw();
                        }
                    }
                }
            }
            */
            //window.Draw();
            //Window window = new Window(0, 0, Console.WindowWidth-1, Console.WindowHeight-1, official, "RAZRAB");
            //Window num1 = new Window(posX,posY,40,15,header,"Okno1");
            //Window num2 = new Window( 30,5,45,15,header,"Okno2");
            //num1.Draw();
            //num2.Draw();
            /*
            while (true)
            {
                string s;
                Console.SetCursorPosition(1,Console.WindowHeight-2);
                Console.Write("$user>>");
                s = Console.ReadLine();
                if (s == "Close")
                {
                    Console.SetCursorPosition(1,Console.WindowHeight-2);
                    Console.Write("$user>>Close>>");
                    s = Console.ReadLine();
                    if (s == "Okno1")
                    {
                        Console.SetCursorPosition(1,Console.WindowHeight-2);
                        Console.Write("$user>>Close>>Okno1");
                    }
                    for (int i = 0; i < windows.Count; i++)
                    {
                        if (s == "Okno1" && i != 1)
                        {
                            windows[i].Draw();
                        }
                    }

                    
                }
                Console.SetCursorPosition(1,Console.WindowHeight-2);
                Console.Write("$user>>");
            }
            */
        }
    }
}