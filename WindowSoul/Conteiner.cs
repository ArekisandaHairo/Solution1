using System;
using System.Collections.Generic;

namespace WindowSoul
{
    public class Conteiner : View
    {
        internal List<View> _listelems;
        internal int _activeElem;

        protected Conteiner(int posX, int posY, int weiht, int height) : base(posX, posY, weiht, height)
        {
            _listelems = new List<View>();
            _activeElem = 2;
        }
        protected int Active(Type a, int i)
        {
            int count = 0;
            for (var index = 1; index < _listelems.Count; index++)
            {
                var view = _listelems[index];
                if (view.GetType() == a && ++count == i)
                {
                    return index;
                }
            }
            return 0;
        }
        internal override int CounterButtons()
        {
            int count = 0;
            for (var index = 0; index < _listelems.Count; index++)
            {
                var view = _listelems[index];
                if (view.GetType() == typeof(Buttons))
                {
                    count++;
                }
            }
            return count;
        }
    }
}