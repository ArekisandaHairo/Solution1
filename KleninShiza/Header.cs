using System;
using static KleninShiza.Drower;

namespace KleninShiza
{
    public class Header : Counteiner
    {
        private string _title;
        public Header(string title,int posX, int posY , int weiht, int height) : base(posX, posY, weiht, height)
        {
            _title = title;
        }
        public void Draw() 
        {
            Console.SetCursorPosition(_posX+1,_posY+1);
            Console.Write(_title);
            Console.SetCursorPosition(_posX+_weiht-8,_posY);
            Console.Write(Constants.Svert + Constants.Razvert + Constants.Close );
            Drawerhor(_posX,_posY+2,_weiht,"#");
        }
    }
}