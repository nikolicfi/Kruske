using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruske
{
    internal class Kruska
    {
        private Point o;
        private int r, dx, dy;
        private int a, b;
        private Color boja;

        Random ran = new Random();
        public Kruska(Point _o)
        {
            o = _o;

            r = ran.Next(30, 50);
            b = r;
            a = r / 2;
            boja = Color.GreenYellow;
        }
        public void Boji(Graphics g)
        {
            Pen olovka = new Pen(Color.Black, 2);
            SolidBrush cetka = new SolidBrush(boja);
            g.DrawLine(olovka, o.X, o.Y - r / 2, o.X, o.Y - (3 * r) / 2);
            g.FillEllipse(cetka, o.X - r / 2, o.Y - r / 2, r, r);
            g.FillEllipse(cetka, o.X - r / 4, o.Y - 2 * r + b, a, b);
            cetka.Color = Color.Green;
            g.FillEllipse(cetka, o.X, o.Y - (3 * r) / 2, r / 2, r / 4);

        }
    }
}
