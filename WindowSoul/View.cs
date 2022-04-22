
using System;

namespace WindowSoul
{
    public class View
    {
        internal int PosX;
        internal int PosY;
        internal int Weiht;
        internal int Height;
        public View(int posX, int posY, int weiht, int height)
        {
            Height = height;
            Weiht = weiht;
            PosX = posX;
            PosY = posY;
        }
        public virtual void Move(int x, int y)
        {
            PosX = x;
            PosY = y;
        }
        public virtual void Change(int x, int y)
        {
            Weiht = x;
            Height = y;
        }

        public virtual void Collapse(ref bool c)
        {
        }
        public virtual void DrawText()
        {
        }
        public void SetPos(int x, int y)
        {
            Console.SetCursorPosition(PosX+1+x,PosY+3+y);
        }
    }
}