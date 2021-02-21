using System;

namespace WorkWithPropreties
{
    class Program
    {
        static int ReadPos()
        {
            int x;
            bool isCorrected = int.TryParse(Console.ReadLine(), out x);
            while (isCorrected == false || x < 0)
            {
                Console.WriteLine("Некорректный ввод. Повторите попытку: ");
                isCorrected = int.TryParse(Console.ReadLine(), out x);
            }
            return x;
        }

        static char ReadSign()
        {
            char sign;
            bool isCorrected = char.TryParse(Console.ReadLine(), out sign);
            while (isCorrected == false)
            {
                Console.WriteLine("Некорректный ввод. Повторите попытку: ");
                isCorrected = char.TryParse(Console.ReadLine(), out sign);
            }
            return sign;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату игрока x: ");
            int x = ReadPos();
            Console.WriteLine("Введите координату игрока y: ");
            int y = ReadPos();
            Console.WriteLine("Введите условное обозначение игрока: ");
            char sign = ReadSign();
            ConsolePerson person = new ConsolePerson(sign, x, y);
            Drawer drawer = new Drawer();
            drawer.DrawPerson(person);
        }
    }

    class ConsolePerson
    {
        public char Sign { get; private set; }
        public int PosX { get; private set; }
        public int PosY { get; private set; }

        public ConsolePerson(char sign, int posX, int posY)
        {
            PosX = posX;
            PosY = posY;
            Sign = sign;
        }
    }

    class Drawer
    {
        public void DrawPerson(ConsolePerson person)
        {
            Console.Clear();
            Console.SetCursorPosition(person.PosX, person.PosY);
            Console.WriteLine(person.Sign);
        }
    }
}
