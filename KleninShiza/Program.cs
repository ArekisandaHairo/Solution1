using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace KleninShiza
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool bkl = true;
            int posX = 20;
            int posY = 10;
            Header official = new Header("RAZRAB", 0, 0, Console.WindowWidth-1, Console.WindowHeight-1, bkl);
            Header header = new Header("Zagalovok", posX, posY, 25, 15, bkl);
            Window win1 = new Window(0, 0, Console.WindowWidth-1, Console.WindowHeight-1, official, "Okno0", bkl);
            
            Window win2 =new Window(posX,posY,40,15,header,"Okno1", bkl);
            Window win3 =new Window( 30,5,45,15,header,"Okno2", bkl);

            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
            while (true)
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    win2.Move(posX+1,posY);
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    win2.Move(posX-1,posY);
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    win2.Move(posX,posY-1);
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    win2.Move(posX,posY+1);
                }
                
            }
            




/*
            while (true)
            {
                int index = 0;
                ConsoleKeyInfo s = Console.ReadKey();
                if (s.Key == ConsoleKey.Q)
                {
                    
                }

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
            Console.ReadKey();
        }
    }
}