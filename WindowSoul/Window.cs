using System;

namespace WindowSoul
{
    public class Window : Conteiner
    {
        private bool _off;

        public Window(int posX, int posY, int weiht, int height, string title, bool off) : base(posX, posY, weiht,
            height)
        {
            _listelems.Add(new Header(title, posX, posY, weiht, height));
            _listelems.Add(new TextInput(posX, posY, weiht, height));
            _listelems.Add(new Text(posX, posY, weiht, height, ""));
            _off = off;
        }

        internal override void ChangeContainerElement(int i)    
        {
            if (_activeElem < _listelems.Count-1) _activeElem = Active(typeof(Buttons), i);
            else _activeElem = Active(typeof(Buttons),0);

        }

        internal override void SetPosElem(int elemIndex, int x, int y)
        {
            _listelems[elemIndex+3].Put_in_place(x,y);
        }
        internal override void AddDelegate(ButtonVoid buttonVoid, int a)
        {
            _listelems[Active(typeof(Buttons),a)].Deg(buttonVoid);
        }

        internal override void AddButtons(Buttons name)
        {
            _listelems.Add(name);
        }

        internal override void AddTexts(Text name)
        {
            _listelems.Add(name);
        }
        internal override void AddTextInputting(TextInput name)
        {
            _listelems.Add(name);
        }

        public void AddSomething(string c)
        {
            /*
             * Button - "btn"
             * Password - "pas"
             * mail - "@"
             * phone - "tel"
             */
            switch (c)
            {
                case "btn":
                    break;
                case "pas":
                    break;
                case "@":
                    break;
                case "tel":
                    break;
            }
            
        }
        internal override void Draw()
        {
            if (_off)
            {
                Drower.DrawBord(PosX, PosY, Weiht, Height);
                Drower.Cler(PosX, PosY, Weiht, Height);
                _listelems[0].Draw();
                for (int index = 1; index < _listelems.Count; index++)
                {
                    var listelem = _listelems[index];
                    SetPos(0, index);
                    if (listelem != _listelems[_activeElem])
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        listelem.Draw();
                    }
                }
                
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                _listelems[_activeElem].Draw();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
        }

        internal override void Inp()
        {
            SetPos(0,0);
            if (_listelems[_activeElem].GetType() == typeof(Text))
            {
                // _listelems[_activeElem].Str() = _listelems[Active(typeof(TextInput),0)].Input();
            }

            if (_listelems[_activeElem].GetType() == typeof(Buttons))
            {
                _listelems[_activeElem].UseMethod();
            }
        }

        internal override void AddContainer()
        {
            foreach (var variable in _listelems)
            {
                Console.WriteLine(variable.GetType());
            }
            Console.SetCursorPosition(0,Console.WindowHeight-1);
            Console.Write(">>");
            string s = Console.ReadLine();
            switch (s)
            {
                case "Txt":
                    Console.SetCursorPosition(0,Console.WindowHeight-1);
                    Console.Write("Create new Text elem>>");
                    Console.SetCursorPosition("Create new txt elem>>".Length,Console.WindowHeight-1);
                    string s1 = Console.ReadLine();
                    _listelems.Add(new Text(PosX,PosY,Weiht,Height,s1));
                    break;
                case "Btn":
                    Console.SetCursorPosition(0,Console.WindowHeight-1);
                    Console.Write("Create new Button elem>>"); 
                    Console.SetCursorPosition("Create new Button elem>>".Length,Console.WindowHeight-1);
                    string s2 = Console.ReadLine();
                    _listelems.Add(new Buttons(PosX,PosY,Weiht,Height,s2));
                    break;
            }
        }

        internal override void Move(int x, int y)
        {
            if (x >= 0 && y >= 0 && x + Weiht < Console.WindowWidth && y + Height < Console.WindowHeight)
            {
                PosX = x;
                PosY = y;
                foreach (var listelem in _listelems) listelem.Move(x,y);
            }
        }

        internal override void Change(int x, int y)
        {
            if (x >= 10 && y >= 10 && x < Console.WindowWidth && y < Console.WindowHeight)
            {
                Weiht = x;
                Height = y;
                foreach (var listelem in _listelems) listelem.Change(x,y);
            }
        }

        internal override void Collapse(ref bool c)
        {
            if (c)
            {
                _off = false;
                c = false;
            }
            else
            {
                _off = true;
                c = true;
            }
        }

        
    }
}