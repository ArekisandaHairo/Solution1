using System;
using static KleninShiza.Drower;

namespace KleninShiza
{
    public class Header : View
    {
        private string _title;
        private bool _off ;
        private bool _expend ;
        public Header(string title,int posX, int posY , int weiht, int height, bool off) : base(posX, posY, weiht, height)
        {
            _title = title;
            _off = off;
        }

        public override void Move(int X, int Y)
        {
            _posX = X;
            _posY = Y;
            
        }
        public void Draw() 
        {
            Console.SetCursorPosition(_posX+1,_posY+1);
            Console.Write(_title);
            
            Drawerhor(_posX,_posY+2,_weiht,"#");
        }
    }
}