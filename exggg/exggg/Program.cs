using System;


namespace exggg
{
    class Button
    {
        public string _caption;
        public string _color;

        public int x { get; set; }
        public int y { get; set; }

        public void _point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString() => _color;
        public int _size;
    }
    class RadioButton : Button
    {
        enum state
        {checkedd, uncheked }

       

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin!");
        }
    }
}
