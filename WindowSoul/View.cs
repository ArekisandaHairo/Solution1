
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
        private string _a;
        

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
        internal virtual ref string Str() => ref _a;

        internal virtual string Input() => null;
        internal virtual void Draw(){ }
        internal virtual void AddButtons( Buttons name){ }
        internal virtual void AddTexts(Text name) {}
        internal virtual void AddTextInputting(TextInput name){}
        protected void SetPos(int x, int y) => Console.SetCursorPosition(PosX+1+x,PosY+3+y);
        internal virtual void AddContainer(){}
        internal virtual void ChangeContainerElement(int i){}
        internal virtual void UseMethod(){ }
        internal virtual void AddDelegate(ButtonVoid buttonVoid, int a){}
        internal virtual void Deg( ButtonVoid buttonVoid){ }

        internal virtual void SetPosElem(int ElemIndex, int x, int y){}
        public virtual void Put_in_place(int x, int y) { }
        internal virtual int CounterButtons() => 0;
        internal virtual void SelectInp(string str) { }
    }
}