using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace oop_lab21_animation
{
    internal class Pagar
    {
        public float x;
        public float y;
        public float sizex;
        public float sizey;
        public Image img_pagar;

        public Pagar()
        {
            x = 0;
            y = 100;
            sizex = 1920;
            sizey = 100;

            img_pagar = new Bitmap(@"E:\КН-3\Лаб_ооп\oop_lab21_animation\oop_lab21_animation\images\Pagar.png");
        }
    }
}
