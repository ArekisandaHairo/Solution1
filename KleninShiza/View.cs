using System;
using System.Collections.Generic;

namespace KleninShiza
{
    public class View
    {
        public ConsoleColor _color;
        protected Header _header;
        protected int _deep;
        protected bool _off;
        protected List<View> _list;
        protected string _title;
        public int _posX;
        public int _posY;
        protected int _weiht;
        protected int _height;
        public View(int posX, int posY, int weiht, int height)
        {
            _height = height;
            _weiht = weiht;
            _posX = posX;
            _posY = posY;
        }
        public View(int posX, int posY, int weiht, int height, string title, bool off)
        {
            _height = height;
            _weiht = weiht;
            _posX = posX;
            _posY = posY;
            _title = title;
            _off = off;
        }
        protected View(List<View> list)
        {
            _list = list;
        }
        public virtual void Move(int X, int Y)
        {
            _posX = X;
            _posY = Y;  
            
        }
    }
}