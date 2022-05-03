using System;
using System.Collections.Generic;

namespace WindowSoul
{
    public class Work
    {
        private List<View> _list;
        public int _activeWin;

        public Work(List<View> list, int activeWin)
        {
            _list = list;
            _activeWin = activeWin;
            
        }

        public void PrintWin()
        {
            Console.Clear();
            foreach (var view in _list)
            {
                if (view != _list[_activeWin])
                {
                    var list = (Window) view;
                    list.Draw();
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            var list1 = (Window) _list[_activeWin];
            list1.Draw();
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        public void AddOkno(int count)
        {
            _list.Add(new Window(10, 10, 20, 15, $"Okno{count}", true));
            PrintWin();
        }

        public void Full_screen_mode(string s)
        {
            _list[_activeWin] = new Window(0, 0, Console.WindowWidth - 1, Console.WindowHeight - 1, s, true);
        }

        public static void Exit()
        {
            string s = "Как я устал пилить эту херню.";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                for (int j = 0; j < Console.WindowWidth; j+=2)
                {
                    Console.Write("Aa");
                }
            }
            Console.SetCursorPosition(Console.WindowWidth / 2 - s.Length / 2, Console.WindowHeight / 2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.SetCursorPosition(0,0);
            System.Threading.Thread.Sleep(5000);
            Environment.Exit(0);
        }
        public void KeysActivity()
        {
            int count = _list.Count;
            int tabCount = 0;
            // Поместить в отдельный класс
            bool c = true, c1 = true;
            int w = _list[_activeWin].Weiht, h = _list[_activeWin].Height;
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
            while (keyInfo.Key != ConsoleKey.Escape)
            {
                keyInfo = Console.ReadKey(true);
                if ((keyInfo.Modifiers & ConsoleModifiers.Alt) != 0)
                {
                    switch (keyInfo.Key)
                    {
                        
                        case ConsoleKey.V: // Добавить новое окно
                            count++;
                            AddOkno(count);
                            break;
                    }
                }

                
                switch (keyInfo.Key)
                {
                    // Перемещение окна
                    case ConsoleKey.RightArrow:
                        _list[_activeWin].Move(_list[_activeWin].PosX + 1, _list[_activeWin].PosY);
                        PrintWin();
                        break;
                    case ConsoleKey.LeftArrow:
                        _list[_activeWin].Move(_list[_activeWin].PosX - 1, _list[_activeWin].PosY);
                        PrintWin();
                        break;
                    case ConsoleKey.UpArrow:
                        _list[_activeWin].Move(_list[_activeWin].PosX, _list[_activeWin].PosY - 1);
                        PrintWin();
                        break;
                    case ConsoleKey.DownArrow:
                        _list[_activeWin].Move(_list[_activeWin].PosX, _list[_activeWin].PosY + 1);
                        PrintWin();
                        break;
                    
                    case ConsoleKey.D1: // скрыть окно
                        _list[_activeWin].Collapse(ref c1);
                        PrintWin();
                        break;
                    case ConsoleKey.D2: // Полный экран
                        if (c)
                        {
                            c = false;
                            _list[_activeWin].Move(0, 0);
                            _list[_activeWin].Change(Console.WindowWidth - 1, Console.WindowHeight - 1);
                            PrintWin();
                        }
                        else
                        {
                            _list[_activeWin].Change(w, h);
                            PrintWin();
                            c = true;
                        }

                        break;
                    case ConsoleKey.D3:
                        break;
                    // Размеры окна
                    case ConsoleKey.I:
                        _list[_activeWin].Change(_list[_activeWin].Weiht, _list[_activeWin].Height + 1);
                        PrintWin();
                        break;
                    case ConsoleKey.J:
                        _list[_activeWin].Change(_list[_activeWin].Weiht - 1, _list[_activeWin].Height);
                        PrintWin();
                        break;
                    case ConsoleKey.K:
                        _list[_activeWin].Change(_list[_activeWin].Weiht, _list[_activeWin].Height - 1);
                        PrintWin();
                        break;
                    case ConsoleKey.L:
                        _list[_activeWin].Change(_list[_activeWin].Weiht + 1, _list[_activeWin].Height);
                        PrintWin();
                        break;
                    
                    case ConsoleKey.E: // Ввод текса в окно
                        _list[_activeWin].Inp();
                        PrintWin();
                        break;
                    case ConsoleKey.Tab: // Нажатие на "Tab" меняет фокус активного окна 
                        if (tabCount < _list.Count - 1)
                        {
                            tabCount++;
                            _activeWin = tabCount;
                            PrintWin();
                        }
                        else if (tabCount == _list.Count - 1)
                        {
                            tabCount = 0;
                            _activeWin = tabCount;
                            PrintWin();
                        }

                        break;
                }
            }
        }
    }
}