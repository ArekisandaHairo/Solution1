using System;

namespace WindowSoul
{
    public class Text_Input : Counteiner
    {
        public Text_Input(int posX, int posY, int weiht, int height) : base(posX, posY, weiht, height)
        {
        }

        public string Input()
        {
            text = Console.ReadLine();
            return text;
        }
    }
}