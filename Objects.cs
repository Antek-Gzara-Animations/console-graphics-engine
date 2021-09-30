using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace console_graphics_engine

{

    public enum Shapes

    {

        custom = 0,

        square = 1

    }

    class objects

    {

    }

    class Object

    {

        public int x { get; set; }

        public int y { get; set; }

        public int Sizex { get; set; }

        public int Sizey { get; set; }

        public ConsoleColor consoleColor { get; set; }

        public Shapes shape { get; set; }

        public Object(int Newx, int Newy, int NewSizex, int NewsizeY, ConsoleColor NewConsoleColor = ConsoleColor.Red,  Shapes NewShape = Shapes.custom)

        {

            x = Newx;

            y = Newy;

            Sizex = NewSizex;

            Sizey = NewsizeY;

            consoleColor = NewConsoleColor;

            shape = NewShape;

        }

        public void Render()

        {

            Console.SetCursorPosition(x, y);

            for(int i = 0; i < Sizey; i++)

            {

                for(int j = 0; j < Sizex; j++)

                {

                    Console.Write('#');

                }

                //Console.SetCursorPosition(x, y + i);

                Console.Write('\n');

            }

        }

        public void ChangePosition(int Newx, int Newy)

        {

            x = Newx;

            y = Newy;

        }

    }

}
