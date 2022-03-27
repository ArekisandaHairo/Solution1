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

        public void Next()
        {
            if (_activeWin < _list.Count-1)
            {
                //_activeWin++;
                var num1 = _list[_activeWin];
                var num2 = _list[_activeWin +1];
                _list[_activeWin] = num2;
                _list[_activeWin + 1] = num1;
            }
            else if ( _activeWin == _list.Count-1)
            {
                //_activeWin = 0;
                var num1 = _list[_list.Count-1];
                var num2 = _list[_activeWin];
                _list[_list.Count-1] = num2;
                _list[_activeWin] = num1;
            }
        }
        public void PrintWin()
        {
            foreach (Window list in _list)
            {
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
