using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace oop_lab21_animation
{
    internal class Cloud
    {
        public float x;
        public float y;
        public float sizex;
        public float sizey;
        public Image img_cloud;

        public Cloud()
        {
            x = 0;
            y = 0;
            sizex = 200;
            sizey = 100;

            img_cloud = new Bitmap(@"E:\КН-3\Лаб_ооп\oop_lab21_animation\oop_lab21_animation\images\Cloud.png");
        }
    }
}
