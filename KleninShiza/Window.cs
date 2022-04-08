using System;
using System.Collections.Generic;

namespace KleninShiza
{
    public class Window : Counteiner
    {
        private bool _off;
        private Header _header;
        public Window(int posX, int posY, int weiht, int height, string title , bool off) : base(posX, posY, weiht, height)
        {
            _header = new Header(title, posX, posY, weiht, height);
            _off = off;
        }

        public void Draw()
        {
            if (_off == true)
            {
                Drower.DrawBord(_posX, _posY,_weiht,_height);
                Drower.cler(_posX,_posY,_weiht,_height);
                Text s = new Text(_posX, _posY, _weiht, _height, "TextInputting...");
                s.TextInputting();
                _header.Draw();
            }
        } 
        public override void Move(int x, int y)
        {
            if (x >= 0 && y >= 0 && x+_weiht < Console.WindowWidth && y+_height < Console.WindowHeight)
            {
                Drower.cler(_posX-1,_posY-1,_weiht+2,_height+2);
                _posX = x;
                _posY = y;
                _header.Move(x,y);
                Draw();
            }
            
        }
        

        
        
    }
}