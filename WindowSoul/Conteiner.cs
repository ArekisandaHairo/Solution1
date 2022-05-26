using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace WindowSoul
{
    public class Conteiner : View
    {
        internal List<View> _listelems;
        internal int _activeElem;

        protected Conteiner(int posX, int posY, int weight, int height) : base(posX, posY, weight, height)
        {
            _listelems = new List<View>();
            _activeElem = 0;
        }
        protected int ElemIntAc(int i)
        {
            var count = 0;
            return _listelems.Where(views => views.GetType() != typeof(Text))
                .Any(views => views.GetType() != typeof(Text) && ++count == i) ? count : count-=1;
        }

        internal override int UsedThings()
        {
            return _listelems.Count(view => view.GetType() != typeof(Text));
        }
    }
}