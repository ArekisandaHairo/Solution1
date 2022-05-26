
using System;

namespace WindowSoul
{
    internal delegate void ButtonVoid();
    public class View
    {
        internal int PosX;
        internal int PosY;
        internal int Weight;
        internal int Height;
        

        protected View(int posX, int posY, int weight, int height)
        {
            Height = height;
            Weight = weight;
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
            Weight = x;
            Height = y;
        }

        internal virtual void Collapse(ref bool c){}
        internal virtual void Inp(){}

        public virtual void SetType(string stri){}

        internal virtual void Draw(){ }
        internal virtual void AddButtons( string content, int x, int y, ButtonVoid method){ }
        internal virtual void AddTexts(string text, int x, int y) {}
        internal virtual void AddTextInputting(string type, int x, int y){}
        protected  void SetPos(int x, int y) => Console.SetCursorPosition(PosX+1+x,PosY+3+y);
        internal virtual void ChangeContainerElement(int i){}
        internal virtual void UseMethod(){ }
        internal virtual void Deg( ButtonVoid buttonVoid){ }

        internal virtual void Put_in_place(int x, int y) { }
        internal virtual int UsedThings() => 0;
    }
}