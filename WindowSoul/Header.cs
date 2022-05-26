using System;
using static WindowSoul.Drower;

namespace WindowSoul
{
    public class Header : Conteiner
    {
        private string _title;

        public Header(string title, int posX, int posY, int weight, int height) : base(posX, posY, weight, height)
        {
            _title = title;
        }

        internal override void Draw()
        {
            Console.SetCursorPosition(PosX + 1, PosY + 1);
            Console.Write(_title);
            Console.SetCursorPosition(PosX + Weight - 8, PosY);
            Console.Write(Constants.Svert + Constants.Razvert + Constants.Close);
            Drawerhor(PosX, PosY + 2, Weight, "#");
        }
        
    }
}