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
        public Work(List<View> list)
        {
            _list = list;
        }

        public void Swap(int i, int j)
        {
            var num1 = _list[i];
            var num2 = _list[j];
            _list[i] = num2;
            _list[j] = num1;
            _activeWin = j;
            _list[j]._color = ConsoleColor.DarkBlue;
            _list[i]._color = ConsoleColor.Black;
        }

        
        public void PrintWin()
        {
            foreach (var view in _list)
            {
                var list = (Window) view;
                list.Draw();
            }
        }
        public void AddOkno()
        {
            _list.Add(new Window(10,10,20,20, "Okno", true, ConsoleColor.Black));
            PrintWin();
        }
    }
}
