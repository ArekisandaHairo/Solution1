using System;

namespace KleninShiza
{
    public class View
    {
        
        protected Header _header;
        protected int _deep;
        protected bool _off;
        protected string _title;
        protected int _posX;
        protected int _posY;
        protected int _weiht;
        protected int _height;
        
        public View(int posX, int posY, int weiht, int height)
        {
            _height = height;
            _weiht = weiht;
            _posX = posX;
            _posY = posY;
        }
        public View(int posX, int posY, int weiht, int height, string title)
        {
            _height = height;
            _weiht = weiht;
            _posX = posX;
            _posY = posY;
            _title = title;
        }

        public View(bool off)
        {
            _off = off;
        }

        protected View()
        {
            throw new NotImplementedException();
        }

        public virtual void Move(int X, int Y)
        {
            _posX = X;
            _posY = Y;  
            
        }
       
    }
}