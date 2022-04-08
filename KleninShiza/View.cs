using System;
using System.Collections.Generic;

namespace KleninShiza
{
    public class View
    {
        public int _posX;
        public int _posY;
        protected int _weiht;
        protected int _height;
        
        public int Tab_Count = 0;

        public View(int posX, int posY, int weiht, int height)
        {
            _height = height;
            _weiht = weiht;
            _posX = posX;
            _posY = posY;
        }
        public virtual void Move(int X, int Y)
        {
            _posX = X;
            _posY = Y;  
            
        }
    }
}