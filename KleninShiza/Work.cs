using System;
using System.Collections.Generic;

namespace KleninShiza
{
    public class Work
    {
        public List<View> _list;
        public int _activeWin;

        public Work(List<View> list, int activeWin)
        {
            _list = list;
            _activeWin = activeWin;
        }

        public void Swap(int i, int j)
        {
            var num1 = _list[i];
            var num2 = _list[j];
            _list[i] = num2;
            _list[j] = num1;
            _activeWin = j;
        }

        
        public void PrintWin()
        {
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
            _list.Add(new Window(17,0,20,10, $"Okno{count}", true));
            PrintWin();
        }
    }
}
