using System;
using System.Collections.Generic;

namespace KleninShiza
{
    public class Work : View
    {
        private List<View> _list;

        public Work( List<View> list ) : base(list)
        {
            _list = list;
        }
        public void addOkno()
        {
            _list.Add(new Window(_posX,_posY,_weiht,_height,_header,_title, _off, ConsoleColor.Black) );
        }

        
    
    }
}
