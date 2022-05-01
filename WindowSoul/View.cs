
using System;
using System.Collections.Generic;

namespace WindowSoul
{
    public class View
    {
        internal int PosX;
        internal int PosY;
        internal int Weiht;
        internal int Height;
        private string a;

        protected View(int posX, int posY, int weiht, int height)
        {
            Height = height;
            Weiht = weiht;
            PosX = posX;
            PosY = posY;
        }

        internal virtual void Move(int x, int y)
        {
            PosX = x;
            PosY = y;
        }

        internal virtual void Change(int x, int y)
        {
            Weiht = x;
            Height = y;
        }

        internal virtual void Collapse(ref bool c){}
        internal virtual void Inp(){}
        internal virtual ref string str() => ref a;

        internal virtual string Input() => null;
        internal virtual void TextI(int x, int y, int w, int h){ }
        protected void SetPos(int x, int y) => Console.SetCursorPosition(PosX+1+x,PosY+3+y);
    }
}