using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace oop_lab21_animation
{
    internal class Pepe
    {
        public float x;
        public float y;
        public int sizex;
        public int sizey;
        public float runXValue;
        public float runYValue;
        public bool left_right;
        public bool keyXDown;
        public bool keyYDown;
        public int num_of_order;
        public Image img_pepe_right;
        public Image img_pepe_left;
        public Image img_pepe_right_smile;
        public Image img_pepe_left_smile;
        public Image img_pepe_right_look1;
        public Image img_pepe_right_look2;
        public Image img_pepe_left_look1;
        public Image img_pepe_left_look2;

        public Pepe(int x, int y)
        {
            img_pepe_right = new Bitmap(@"E:\КН-3\Лаб_ооп\oop_lab21_animation\oop_lab21_animation\images\Pepe_right.png");
            img_pepe_left = new Bitmap(@"E:\КН-3\Лаб_ооп\oop_lab21_animation\oop_lab21_animation\images\Pepe_left.png");
            img_pepe_right_smile = new Bitmap(@"E:\КН-3\Лаб_ооп\oop_lab21_animation\oop_lab21_animation\images\Pepe_right_smile.png");
            img_pepe_left_smile = new Bitmap(@"E:\КН-3\Лаб_ооп\oop_lab21_animation\oop_lab21_animation\images\Pepe_left_smile.png");
            img_pepe_right_look1 = new Bitmap(@"E:\КН-3\Лаб_ооп\oop_lab21_animation\oop_lab21_animation\images\Pepe_right_look1.png");
            img_pepe_right_look2 = new Bitmap(@"E:\КН-3\Лаб_ооп\oop_lab21_animation\oop_lab21_animation\images\Pepe_right_look2.png");
            img_pepe_left_look1 = new Bitmap(@"E:\КН-3\Лаб_ооп\oop_lab21_animation\oop_lab21_animation\images\Pepe_left_look1.png");
            img_pepe_left_look2 = new Bitmap(@"E:\КН-3\Лаб_ооп\oop_lab21_animation\oop_lab21_animation\images\Pepe_left_look2.png");
            this.x = x;
            this.y = y;
            sizex = 68;
            sizey = 104;
            runXValue = 0;
            runYValue = 0;
            left_right = true;
            keyXDown = false;
            keyYDown = false;
            num_of_order = 1;
        }
        

        public void PaintPepe()
        {
            
        }
    }
}
