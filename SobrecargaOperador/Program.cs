// See https://aka.ms/new-console-template for more information

namespace SobrecargaOperador
{
    class Ponto
    {
        public int x { get; set; }
        public int y { get; set; }

        public Ponto()
        {
            x = 0;
            y = 0;
        }
        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public string imprime()
        {
            return $"X = {this.x} e Y = {this.y}";
        }

        public static Ponto operator ++(Ponto p)
        {
            Ponto pt = p;

            pt.x = pt.x + 1;
            pt.y = pt.y + 1;

            return pt;
        }
        public static Ponto operator +(Ponto p1, Ponto p2)
        {
            Ponto pt = new Ponto();

            pt.x = p1.x + p2.x;
            pt.y = p1.y + p2.y;

            return pt;

        }

    }
    class Program
    {
        static void Main()
        {
            Ponto p = new Ponto();
            Ponto pp = new Ponto(2, 6);
            Ponto ppp = new Ponto(4, 4);

            p = pp + ppp;

            Console.WriteLine(p.x);
            Console.WriteLine(p.y);

            p = p++;

            Console.WriteLine(p.x);
            Console.WriteLine(p.y);

        }
    }
}
