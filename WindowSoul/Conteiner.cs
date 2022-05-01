using System;
using System.Collections.Generic;

namespace WindowSoul
{
    public class Conteiner : View
    {
        internal List<View> _listelems;

        protected Conteiner(int posX, int posY, int weiht, int height) : base(posX, posY, weiht, height)
        {
            _listelems = new List<View>();
        }
        protected int Active(Type a)
        {
            for (var index = 0; index < _listelems.Count; index++)
            {
                var view = _listelems[index];
                if (view.GetType() == a) return index;
            }
            return 0;
        }
    }
}