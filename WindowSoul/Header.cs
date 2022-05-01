using System;
using static WindowSoul.Drower;

namespace WindowSoul
{
    public class Header : Conteiner
    {
        private string _title;

        public Header(string title, int posX, int posY, int weiht, int height) : base(posX, posY, weiht, height)
        {
            _title = title;
        }

        public void Draw()
        {
            Console.SetCursorPosition(PosX + 1, PosY + 1);
            Console.Write(_title);
            Console.SetCursorPosition(PosX + Weiht - 8, PosY);
            Console.Write(Constants.Svert + Constants.Razvert + Constants.Close);
            Drawerhor(PosX, PosY + 2, Weiht, "#");
        }
    }
}