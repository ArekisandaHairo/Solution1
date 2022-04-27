using System;

namespace WindowSoul
{
    public class AvtoReg : View
    {
        private Window _window;
        public AvtoReg(int x, int y, int w, int h) : base(x,y,w,h)
        {
            _window = new Window(x,y,w,h,"Registration", true);
        }

        public void draw()
        {
            _window.Draw();
        }

        private void Signin()
        {
            _window.Draw();
            SetPos(30,4);
            Console.Write("Вход");
            // while (true)
            // {
                
            // }
        }

        private void Registration()
        {
            _window.Draw();
            SetPos(30,4);
            Console.Write("Регистрация");
            // while (true)
            // {
                
            // }
        }

        public void Rabota()
        {
            SetPos(30,4);
            Console.Write("Приветствую, пожалуйста войдите в систему или зарегестрируйтесь.");
            
            SetPos(30,8);
            Console.Write("Войти");
            
            SetPos(30,12);
            Console.Write("Зарегистрироваться");
            ConsoleKeyInfo consoleKeyInfo = new ConsoleKeyInfo();
            Console.ReadKey(true);
            while (consoleKeyInfo.Key != ConsoleKey.Escape)
            {
                consoleKeyInfo = Console.ReadKey();
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.UpArrow :
                        SetPos(30,12);
                        Console.Write("Зарегистрироваться");
                        Console.ForegroundColor = ConsoleColor.Green;
                        SetPos(30,8);
                        Console.Write("Войти");
                        Console.ResetColor();
                        consoleKeyInfo = Console.ReadKey();
                        if (consoleKeyInfo.Key == ConsoleKey.Enter) Signin();
                            break;
                    case ConsoleKey.DownArrow :
                        SetPos(30,8);
                        Console.Write("Войти");
                        Console.ForegroundColor = ConsoleColor.Green;
                        SetPos(30,12);
                        Console.Write("Зарегистрироваться");
                        Console.ResetColor();
                        consoleKeyInfo = Console.ReadKey();
                        if (consoleKeyInfo.Key == ConsoleKey.Enter) Registration();
                        break;
                }
            }
            
        }
        
    }
}