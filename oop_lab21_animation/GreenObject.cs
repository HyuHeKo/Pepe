using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace oop_lab21_animation
{
    internal class GreenObject
    {
        public float x;
        public float y;
        public float sizex;
        public float sizey;
        public int num_of_order;
        public Image tree;
        public Image bush;

        public GreenObject(float sizex, float sizey)
        {
            x = 0;
            y = 0;
            this.sizex = sizex;
            this.sizey = sizey;
            num_of_order = 1;
            tree = new Bitmap(@"E:\КН-3\Лаб_ооп\oop_lab21_animation\oop_lab21_animation\images\Tree.png");
            bush = new Bitmap(@"E:\КН-3\Лаб_ооп\oop_lab21_animation\oop_lab21_animation\images\Bush.png");
        }
    }
}
