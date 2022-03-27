using System;
using System.Collections.Generic;

namespace KleninShiza
{
    public class Window : View
    {
        public Window(int posX, int posY, int weiht, int height, string title , bool off, ConsoleColor color) : base(posX, posY, weiht, height, title, off)
        {
            _header = new Header(title, posX, posY, weiht, height, off);
            _color = color;
        }

        public void Draw()
        {
            if (_off == true)
            {
                Console.BackgroundColor = _color;
                DrawBord();
                Drower.cler(_posX,_posY,_weiht,_height);
                TextInput s = new TextInput(_posX, _posY, _weiht, _height, "TextInputting...");
                s.TextInputting();
                _header.Draw();
                Console.ResetColor();
            }
        } 
        public override void Move(int x, int y)
        {
            Drower.cler(_posX-1,_posY-1,_weiht+2,_height+2);
            _posX = x;
            _posY = y;
            _header.Move(x,y);
            Draw();
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