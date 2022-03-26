using System;
using System.Collections.Generic;

namespace KleninShiza
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
        public Work(List<View> list)
        {
            _list = list;
        }

        public void AddOkno()
        {
            _list.Add(new Window(10,10,20,20, "Okno", true, ConsoleColor.Black));
        }

        
    
    }
}
