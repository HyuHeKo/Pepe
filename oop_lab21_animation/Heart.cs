using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace oop_lab21_animation
{
    internal class Heart
    {
        public float x;
        public float y;
        public float sizex;
        public float sizey;
        public int num_of_order;
        public Image heart_void;
        public Image heart_1;
        public Image heart_2;
        public Image heart_3;
        public Image heart_4;
        public Image heart_full;

        public Heart()
        {
            x = 0;
            y = 0;
            sizex = 44;
            sizey = 44;

            heart_void = new Bitmap(@"E:\КН-3\Лаб_ооп\oop_lab21_animation\oop_lab21_animation\images\Heart_void.png");
            heart_1 = new Bitmap(@"E:\КН-3\Лаб_ооп\oop_lab21_animation\oop_lab21_animation\images\Heart_1.png");
            heart_2 = new Bitmap(@"E:\КН-3\Лаб_ооп\oop_lab21_animation\oop_lab21_animation\images\Heart_2.png");
            heart_3 = new Bitmap(@"E:\КН-3\Лаб_ооп\oop_lab21_animation\oop_lab21_animation\images\Heart_3.png");
            heart_4 = new Bitmap(@"E:\КН-3\Лаб_ооп\oop_lab21_animation\oop_lab21_animation\images\Heart_4.png");
            heart_full = new Bitmap(@"E:\КН-3\Лаб_ооп\oop_lab21_animation\oop_lab21_animation\images\Heart_full.png");

            num_of_order = 1;
        }

    }
}
