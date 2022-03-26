using System;
using System.Collections.Generic;

namespace KleninShiza
{
    public class Work : View
    {
        private List<View> _v;


        public void addOkno()
        {
            _v.Add(new Window(_posX,_posY,_weiht,_height,_header,_title,_off) );
        }

        
    
    }
}