using System;
using System.Collections.Generic;

namespace KleninShiza
{
    public class Window : View
    {
        
        public Window(int posX, int posY, int weiht, int height, Header header, string title , bool off) : base(posX, posY, weiht, height, title)
        {
            _header = new Header(title, posX, posY, weiht, height, off);
        }

        public Window(bool off) : base(off)
        {
            _off = off;
        }


        public ConsoleColor color(ConsoleColor n)
        {
            return n;
        }
        public void Draw()
        {
            DrawBord();
            Drower.cler(_posX,_posY,_weiht,_height);
            _header.Draw();
            Console.ResetColor();
        }

        public override void Move(int x, int y)
        {
            base.Move(_posX, _posY);
        }
        private void DrawBord()
        {
            Drower.Drawerhor(_posX, _posY, _weiht, "#");
            
            Drower.Drawerhor(_posX, _posY + _height, _weiht, "#");
            
            Drower.Drawervert(_posX, _posY , _height, "#");
            
            Drower.Drawervert(_posX + _weiht, _posY, _height, "#");
        }
    }
}