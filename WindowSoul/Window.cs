using System;
using System.Linq;
using System.Threading;

namespace WindowSoul
{
    public class Window : Conteiner
    {
        private bool _off;
        private Header _header;

        public Window(int posX, int posY, int weight, int height, string title, bool off) : base(posX, posY, weight,
            height)
        {
            _header = new Header(title, posX, posY, weight, height);
            _off = off;
        }

        internal override void ChangeContainerElement(int i) => _activeElem = ElemIntAc(i);

        internal override string SearchTag(string tag)
        {
            var str = "";
            foreach (var VARIABLE in _listelems.Where(VARIABLE => VARIABLE.GetTag() == tag))
            {
                str = VARIABLE.GetInfoT();
            } return str;
        }

        

        internal override void AddButtons(string content, int x, int y, ButtonVoid method, string tag)
        {
            _listelems.Add(new Buttons(PosX, PosY, Weight, Height, content));
            _listelems[_listelems.Count - 1].Put_in_place(x,y);
            _listelems[_listelems.Count - 1].Deg(method);
            _listelems[_listelems.Count - 1].SetTag(tag);
        }

        internal override void AddTexts(string text, int x, int y, string tag)
        {
            _listelems.Add(new Text(PosX, PosY, Weight, Height, text));
            _listelems[_listelems.Count - 1].Put_in_place(x,y);
            _listelems[_listelems.Count - 1].SetTag(tag);
        }

        internal override void AddTextInputting(string type, int x, int y, string tag)
        {
            _listelems.Add(new TextInput(PosX, PosY, Weight, Height));
            _listelems[_listelems.Count - 1].SetType(type);
            _listelems[_listelems.Count - 1].Put_in_place(x,y);
            _listelems[_listelems.Count - 1].SetTag(tag);
        }


        internal override void Draw()
        {
            if (_off)
            {
                Drower.DrawBord(PosX, PosY, Weight, Height);
                Drower.Cler(PosX, PosY, Weight, Height);
                _header.Draw();
                for (int index = 0; index < _listelems.Count; index++)
                {
                    var listelem = _listelems[index];
                    SetPos(0, index);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    listelem.Draw();
                }

                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                if (_listelems[_activeElem].GetType() != typeof(Text)) _listelems[_activeElem].Draw();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
        }

        internal override void Inp()
        {
            SetPos(0, 0);
            _listelems[_activeElem].UseMethod();
        }

        // internal override void AddContainer()
        // {
        //     foreach (var variable in _listelems)
        //     {
        //         Console.WriteLine(variable.GetType());
        //     }
        //
        //     Console.SetCursorPosition(0, Console.WindowHeight - 1);
        //     Console.Write(">>");
        //     string s = Console.ReadLine();
        //     switch (s)
        //     {
        //         case "Txt":
        //             Console.SetCursorPosition(0, Console.WindowHeight - 1);
        //             Console.Write("Create new Text elem>>");
        //             Console.SetCursorPosition("Create new txt elem>>".Length, Console.WindowHeight - 1);
        //             string s1 = Console.ReadLine();
        //             _listelems.Add(new Text(PosX, PosY, Weight, Height, s1));
        //             break;
        //         case "Btn":
        //             Console.SetCursorPosition(0, Console.WindowHeight - 1);
        //             Console.Write("Create new Button elem>>");
        //             Console.SetCursorPosition("Create new Button elem>>".Length, Console.WindowHeight - 1);
        //             string s2 = Console.ReadLine();
        //             _listelems.Add(new Buttons(PosX, PosY, Weight, Height, s2));
        //             break;
        //     }
        // }

        internal override void Move(int x, int y)
        {
            if (x >= 0 && y >= 0 && x + Weight < Console.WindowWidth && y + Height < Console.WindowHeight)
            {
                PosX = x;
                PosY = y;
                _header.Move(x, y);
                foreach (var listelem in _listelems) listelem.Move(x, y);
            }
        }

        internal override void Change(int x, int y)
        {
            if (x >= 10 && y >= 10 && x < Console.WindowWidth && y < Console.WindowHeight)
            {
                Weight = x;
                Height = y;
                _header.Change(x, y);
                foreach (var listelem in _listelems) listelem.Change(x, y);
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