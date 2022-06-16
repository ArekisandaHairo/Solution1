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
        // private int _count;

        protected Conteiner(int posX, int posY, int weight, int height) : base(posX, posY, weight, height)
        {
            _listelems = new List<View>();
            _activeElem = 0;
        }

        protected int ElemIntAc(int i)
        {
            var _count = 0;
            var asd = _listelems.Where(view => view.GetType() != typeof(Text))
                .Select(variable => _listelems.FindIndex(v => v == variable)).ToList();

            foreach (var VARIABLE in asd.Where(variable => ++_count == i))
            {
                _count = VARIABLE;
                break;
            }

            return _count;
            // var any = false;
            // foreach (var views in _listelems.Where(views =>
            //              views.GetType() != typeof(Text)))
            // {
            //     _count++;
            //     if (_count != i) continue;
            //     any = true;
            //     break;
            // }
            //
            // if (any)
            //     return _count;
            // else
            //     return _count = _listelems.FindIndex(v => v.GetType() != typeof(Text));
        }

        internal override int UsedThings()
        {
            return _listelems.Count(view => view.GetType() != typeof(Text));
        }
    }
}