using System;

namespace WindowSoul
{
    static class Drower
    {
        public static void Cler(int posX, int posY, int weiht, int height)
        {
            for (int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(posX + 1, posY + i);
                for (int j = 1; j < weiht; j++)
                {
                    Console.Write(" ");
                }
            }
        }

        public static void DrawBord(int x, int y, int w, int h)
        {
            Drawerhor(x, y, w, "#");
            Drawerhor(x, y + h, w, "#");
            Drawervert(x, y, h, "#");
            Drawervert(x + w, y, h, "#");
            
        }

        public static void Drawerhor(int posX, int posY, int len, string c)
        {
            Console.SetCursorPosition(posX, posY);
            for (int i = 0; i <= len; i++)
            {
                Console.Write(c);
            }
        }

        public static void Drawervert(int posX, int posY, int len, string c)
        {
            Console.SetCursorPosition(posX, posY);
            for (int i = 0; i <= len; i++)
            {
                Console.Write(c);
                Console.SetCursorPosition(posX, i + posY);
            }
        }
    }
}