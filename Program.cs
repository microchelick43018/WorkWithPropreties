using System;

namespace WorkWithPropreties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату игрока x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату игрока y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Position position = new Position(x, y);
            Console.WriteLine("Введите условное обозначение игрока: ");
            ConsolePerson person = new ConsolePerson(Convert.ToChar(Console.ReadLine()), position);
            person.DrawPerson();
        }
    }

    class ConsolePerson
    {
        private char _sign;
        private Position _position;

        public char Sign { get => _sign; private set => _sign = value; }
        public Position Position { get => _position; private set => _position = value; }

        public ConsolePerson(char sign, Position position)
        {
            Sign = sign;
            Position = position;
        }

        public void DrawPerson()
        {
            Console.Clear();
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.WriteLine(Sign);
        }
    }

    class Position
    {
        private int _x;
        private int _y;

        public int X
        {
            get => _x;
            private set
            {
                if (value < 0)
                {
                    throw new Exception("отрицательная координата!");
                }
                else
                {
                    _x = value;
                }
            }
        }

        public int Y
        { 
            get => _y;
            private set
            {
                if (value < 0)
                {
                    throw new Exception("отрицательная координата!");
                }
                else
                {
                    _y = value;
                }
            }
        }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

}
