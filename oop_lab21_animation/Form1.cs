using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace oop_lab21_animation
{
    public partial class Form1 : Form
    {
        Pepe pepe_1;
        Pepe pepe_2;
        Heart heart;
        Pagar pagar;
        GreenObject tree;
        GreenObject bush_1;
        GreenObject bush_2;
        Cloud cloud;
        bool trigerBox;
        int time_in_timer = 0;
        int time_in_timer_look1 = 0;
        int time_in_timer_look2 = 0;

        public Form1()
        {
            InitializeComponent();
            Invalidate();
            Init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        public void Init()
        {
            pepe_1 = new Pepe(300, 200);
            pepe_2 = new Pepe(400, 200);
            heart = new Heart();
            pagar = new Pagar();
            tree = new GreenObject(300, 300);
            bush_1 = new GreenObject(110, 55);
            bush_2 = new GreenObject(140, 70);
            cloud = new Cloud();

            timer1.Interval = 10;
            timer1.Tick += new EventHandler(update);
            timer1.Start();
        }

        private void update(object sender, EventArgs e)
        {
            pepe_1.num_of_order = 1;
            pepe_2.num_of_order = 1;
            heart.num_of_order = 1;
            tree.num_of_order = 1;
            bush_1.num_of_order = 1;
            bush_2.num_of_order = 1;

            Pepe_Move(pepe_1);
            Pepe_Move(pepe_2);
            pepe_1_label.Location = new Point(Convert.ToInt32(pepe_1.x - (pepe_1.sizex / 2) + ((pepe_1.sizex - pepe_1_label.Width) / 2)), Convert.ToInt32(pepe_1.y + (pepe_1.sizey / 2)/* - pepe_1_label.Height*/));
            pepe_2_label.Location = new Point(Convert.ToInt32(pepe_2.x - (pepe_2.sizex / 2) + ((pepe_2.sizex - pepe_2_label.Width) / 2)), Convert.ToInt32(pepe_2.y + (pepe_2.sizey / 2)/* - pepe_2_label.Height*/));

            if (pepe_1.left_right && !pepe_2.left_right)
            {
                if (pepe_1.y <= pepe_2.y)
                {
                    if (pepe_2.y - pepe_1.y <= 10 && pepe_2.y - pepe_1.y >= -10)
                    {
                        if (pepe_2.x - pepe_1.x <= 80 && pepe_2.x - pepe_1.x >= 60)
                        {
                            trigerBox = true;
                        }
                        else
                            trigerBox = false;
                    }
                }
            }
            else if (!pepe_1.left_right && pepe_2.left_right)
            {
                if (pepe_1.y >= pepe_2.y)
                {
                    if (pepe_1.y - pepe_2.y <= 10 && pepe_1.y - pepe_2.y >= -10)
                    {
                        if (pepe_1.x - pepe_2.x <= 80 && pepe_1.x - pepe_2.x >= 60)
                            trigerBox = true;
                        else
                            trigerBox = false;
                    }
                }
            }
            else
                trigerBox = false;


            if (pepe_1.x < pepe_2.x)
                heart.x = (pepe_2.x + pepe_1.x) / 2;
            else
                heart.x = (pepe_1.x + pepe_2.x) / 2;

            if (pepe_1.y < pepe_2.y)
                heart.y = pepe_1.y - pepe_1.sizey / 1.1f;
            else
                heart.y = pepe_2.y - pepe_2.sizey / 1.1f;

            tree.x = 628;
            tree.y = this.Height - 370 - tree.sizey;
            bush_1.x = 100;
            bush_1.y = this.Height - 85 - bush_1.sizey;
            bush_2.x = 900;
            bush_2.y = this.Height - 100 - bush_2.sizey;

            if (cloud.x <= this.Width)
                cloud.x += 2;
            else
                cloud.x = 0 - cloud.sizex;
            cloud.y = pagar.y - 80;

            if (pepe_1.y > pepe_2.y)
                pepe_1.num_of_order++;
            if (pepe_1.y + pepe_1.sizey / 2 > tree.y + tree.sizey)
                pepe_1.num_of_order++;
            if (pepe_1.y + pepe_1.sizey / 2 > bush_1.y + bush_1.sizey)
                pepe_1.num_of_order++;
            if (pepe_1.y + pepe_1.sizey / 2 > bush_2.y + bush_2.sizey)
                pepe_1.num_of_order++;

            if (pepe_2.y > pepe_1.y)
                pepe_2.num_of_order++;
            if (pepe_2.y + pepe_2.sizey / 2 > tree.y + tree.sizey)
                pepe_2.num_of_order++;
            if (pepe_2.y + pepe_2.sizey / 2 > bush_1.y + bush_1.sizey)
                pepe_2.num_of_order++;
            if (pepe_2.y + pepe_2.sizey / 2 > bush_2.y + bush_2.sizey)
                pepe_2.num_of_order++;

            if (tree.y + tree.sizey > pepe_1.y + pepe_1.sizey / 2)
                tree.num_of_order++;
            if (tree.y + tree.sizey > pepe_2.y + pepe_2.sizey / 2)
                tree.num_of_order++;
            if (tree.y + tree.sizey > bush_1.y + bush_1.sizey)
                tree.num_of_order++;
            if (tree.y + tree.sizey > bush_2.y + bush_2.sizey)
                tree.num_of_order++;

            if (bush_1.y + bush_1.sizey > pepe_1.y + pepe_1.sizey / 2)
                bush_1.num_of_order++;
            if (bush_1.y + bush_1.sizey > pepe_2.y + pepe_2.sizey / 2)
                bush_1.num_of_order++;
            if (bush_1.y + bush_1.sizey > tree.y + tree.sizey)
                bush_1.num_of_order++;
            if (bush_1.y + bush_1.sizey > bush_2.y + bush_2.sizey)
                bush_1.num_of_order++;

            if (bush_2.y + bush_2.sizey > pepe_1.y + pepe_1.sizey / 2)
                bush_2.num_of_order++;
            if (bush_2.y + bush_2.sizey > pepe_2.y + pepe_2.sizey / 2)
                bush_2.num_of_order++;
            if (bush_2.y + bush_2.sizey > tree.y + tree.sizey)
                bush_2.num_of_order++;
            if (bush_2.y + bush_2.sizey > bush_1.y + bush_1.sizey)
                bush_2.num_of_order++;

            if (time_in_timer < 5000)
                time_in_timer += timer1.Interval;
            if(time_in_timer_look1 < 15000)
                time_in_timer_look1 += timer1.Interval;
            if (time_in_timer_look2 < 15000)
                time_in_timer_look2 += timer1.Interval;
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //pepe_1
            if (e.KeyCode == Keys.A)
            {
                pepe_1.left_right = false;
                pepe_1.runXValue = -4.5f;
                pepe_1.keyXDown = true;
                time_in_timer_look1 = 0;
            }
            if (e.KeyCode == Keys.D)
            {
                pepe_1.left_right = true;
                pepe_1.runXValue = 4.5f;
                pepe_1.keyXDown = true;
                time_in_timer_look1 = 0;
            }
            if (e.KeyCode == Keys.W)
            {
                pepe_1.runYValue = -3f;
                pepe_1.keyYDown = true;
                time_in_timer_look1 = 0;
            }
            if (e.KeyCode == Keys.S)
            {
                pepe_1.runYValue = 3f;
                pepe_1.keyYDown = true;
                time_in_timer_look1 = 0;
            }

            //pepe_2
            if (e.KeyCode == Keys.Left)
            {
                pepe_2.left_right = false;
                pepe_2.runXValue = -4.5f;
                pepe_2.keyXDown = true;
                time_in_timer_look2 = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                pepe_2.left_right = true;
                pepe_2.runXValue = 4.5f;
                pepe_2.keyXDown = true;
                time_in_timer_look2 = 0;
            }
            if (e.KeyCode == Keys.Up)
            {
                pepe_2.runYValue = -3f;
                pepe_2.keyYDown = true;
                time_in_timer_look2 = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                pepe_2.runYValue = 3f;
                pepe_2.keyYDown = true;
                time_in_timer_look2 = 0;
            }

            time_in_timer = 0;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //pepe_1
            if (e.KeyCode == Keys.A)
            {
                pepe_1.keyXDown = false;
                time_in_timer_look1 = 0;
            }

            if (e.KeyCode == Keys.D)
            {
                pepe_1.keyXDown = false;
                time_in_timer_look1 = 0;
            }

            if (e.KeyCode == Keys.W)
            {
                pepe_1.keyYDown = false;
                time_in_timer_look1 = 0;
            }

            if (e.KeyCode == Keys.S)
            {
                pepe_1.keyYDown = false;
                time_in_timer_look1 = 0;
            }


            if (!pepe_1.keyXDown)
                pepe_1.runXValue = 0;
            if (!pepe_1.keyYDown)
                pepe_1.runYValue = 0;

            //pepe_2
            if (e.KeyCode == Keys.Left)
            {
                pepe_2.keyXDown = false;
                time_in_timer_look2 = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                pepe_2.keyXDown = false;
                time_in_timer_look2 = 0;
            }
            if (e.KeyCode == Keys.Up)
            {
                pepe_2.keyYDown = false;
                time_in_timer_look2 = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                pepe_2.keyYDown = false;
                time_in_timer_look2 = 0;
            }

            if (!pepe_2.keyXDown)
                pepe_2.runXValue = 0;
            if (!pepe_2.keyYDown)
                pepe_2.runYValue = 0;

            time_in_timer = 0;
        }

        private void Paint_Pepe(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            Rectangle road = new Rectangle(0, this.Height - 350, this.Width, 200);
            Rectangle grass = new Rectangle(0, this.Height - 450, this.Width, 500);
            SolidBrush sb_road = new SolidBrush(Color.DimGray);
            SolidBrush sb_grass = new SolidBrush(Color.LimeGreen);
            SolidBrush sb_line = new SolidBrush(Color.White);
            Pen pen_LightGray = new Pen(Color.LightGray, 15);
            Pen pen_Gray_10 = new Pen(Color.Gray, 10);
            Pen pen_Gray_4 = new Pen(Color.Gray, 4);
            Pen pen_DarkGray_4 = new Pen(Color.DimGray, 4);

            float x1 = 5;
            float y1 = this.Height - 343;
            float x2 = 20;
            float y2 = this.Height - 358;
            int x_x = 40;

            g.DrawImage(cloud.img_cloud, cloud.x, cloud.y, cloud.sizex, cloud.sizey);

            g.FillRectangle(sb_grass, grass);
            g.FillRectangle(sb_road, road);
            g.DrawLine(pen_LightGray, 0, this.Height - 350, this.Width, this.Height - 350);
            g.DrawLine(pen_Gray_10, 0, this.Height - 337, this.Width, this.Height - 337);
            g.DrawLine(pen_LightGray, 0, this.Height - 150, this.Width, this.Height - 150);
            for (int i = 0; i < 50; i++)
            {
                g.DrawLine(pen_Gray_4, x1, y1, x2, y2);
                x1 += x_x;
                x2 += x_x;
            }
            x1 = 10;
            x2 = 25;
            y1 = this.Height - 143;
            y2 = this.Height - 158;
            for (int i = 0; i < 50; i++)
            {
                g.DrawLine(pen_Gray_4, x1, y1, x2, y2);
                x1 += x_x;
                x2 += x_x;
            }
            x1 = 5;
            x2 = 5;
            y1 = this.Height - 343;
            y2 = this.Height - 332;
            for (int i = 0; i < 50; i++)
            {
                g.DrawLine(pen_DarkGray_4, x1, y1, x2, y2);
                x1 += x_x;
                x2 += x_x;
            }
            x_x = 150;
            x1 = 15;
            x2 = 30;
            y1 = this.Height - 255;
            y2 = this.Height - 270;

            for (int i = 0; i < 20; i++)
            {
                Point[] line = { new Point(Convert.ToInt32(x1), Convert.ToInt32(y1)), new Point(Convert.ToInt32(x2), Convert.ToInt32(y2)), new Point(Convert.ToInt32(x2 + 80), Convert.ToInt32(y2)), new Point(Convert.ToInt32(x1 + 80), Convert.ToInt32(y1)) };
                g.FillPolygon(sb_line, line);
                x1 += x_x;
                x2 += x_x;
            }

            g.DrawImage(pagar.img_pagar, pagar.x, pagar.y - pagar.sizey + this.Height - 540, pagar.sizex, pagar.sizey);

            for (int i = 1; i <=5; i++)
            {
                if(pepe_1.num_of_order == i)
                {
                    if (pepe_1.left_right)
                        g.DrawImage(pepe_1.img_pepe_right, pepe_1.x - (pepe_1.sizex / 2), pepe_1.y - (pepe_1.sizey / 2), pepe_1.sizex, pepe_1.sizey);
                    if (!pepe_1.left_right)
                        g.DrawImage(pepe_1.img_pepe_left, pepe_1.x - (pepe_1.sizex / 2), pepe_1.y - (pepe_1.sizey / 2), pepe_1.sizex, pepe_1.sizey);
                }
                if (pepe_2.num_of_order == i)
                {
                    if (pepe_2.left_right)
                        g.DrawImage(pepe_2.img_pepe_right, pepe_2.x - (pepe_2.sizex / 2), pepe_2.y - (pepe_2.sizey / 2), pepe_2.sizex, pepe_2.sizey);
                    if (!pepe_2.left_right)
                        g.DrawImage(pepe_2.img_pepe_left, pepe_2.x - (pepe_2.sizex / 2), pepe_2.y - (pepe_2.sizey / 2), pepe_2.sizex, pepe_2.sizey);
                }
                if (tree.num_of_order == i)
                    g.DrawImage(tree.tree, tree.x, tree.y, tree.sizex, tree.sizey);
                if (bush_1.num_of_order == i)
                    g.DrawImage(bush_1.bush, bush_1.x, bush_1.y, bush_1.sizex, bush_1.sizey);
                if (bush_2.num_of_order == i)
                    g.DrawImage(bush_2.bush, bush_2.x, bush_2.y, bush_2.sizex, bush_2.sizey);
            }

            if (pepe_1.left_right)
            {
                if (time_in_timer_look1 >= 13800)
                    time_in_timer_look1 = 0;
                else if (time_in_timer_look1 >= 13400)
                    g.DrawImage(pepe_1.img_pepe_right_look1, pepe_1.x - (pepe_1.sizex / 2), pepe_1.y - (pepe_1.sizey / 2), pepe_1.sizex, pepe_1.sizey);
                else if (time_in_timer_look1 >= 13000)
                    g.DrawImage(pepe_1.img_pepe_right_look2, pepe_1.x - (pepe_1.sizex / 2), pepe_1.y - (pepe_1.sizey / 2), pepe_1.sizex, pepe_1.sizey);
                else if (time_in_timer_look1 >= 12000)
                    g.DrawImage(pepe_1.img_pepe_right_look1, pepe_1.x - (pepe_1.sizex / 2), pepe_1.y - (pepe_1.sizey / 2), pepe_1.sizex, pepe_1.sizey);
            }
            if (!pepe_1.left_right)
            {
                if (time_in_timer_look1 >= 13800)
                    time_in_timer_look1 = 0;
                else if (time_in_timer_look1 >= 13400)
                    g.DrawImage(pepe_1.img_pepe_left_look1, pepe_1.x - (pepe_1.sizex / 2), pepe_1.y - (pepe_1.sizey / 2), pepe_1.sizex, pepe_1.sizey);
                else if (time_in_timer_look1 >= 13000)
                    g.DrawImage(pepe_1.img_pepe_left_look2, pepe_1.x - (pepe_1.sizex / 2), pepe_1.y - (pepe_1.sizey / 2), pepe_1.sizex, pepe_1.sizey);
                else if (time_in_timer_look1 >= 12000)
                    g.DrawImage(pepe_1.img_pepe_left_look1, pepe_1.x - (pepe_1.sizex / 2), pepe_1.y - (pepe_1.sizey / 2), pepe_1.sizex, pepe_1.sizey);
            }
            if (pepe_2.left_right)
            {
                if (time_in_timer_look2 >= 15800)
                    time_in_timer_look2 = 0;
                else if (time_in_timer_look2 >= 15400)
                    g.DrawImage(pepe_2.img_pepe_right_look1, pepe_2.x - (pepe_2.sizex / 2), pepe_2.y - (pepe_2.sizey / 2), pepe_2.sizex, pepe_2.sizey);
                else if (time_in_timer_look2 >= 15000)
                    g.DrawImage(pepe_2.img_pepe_right_look2, pepe_2.x - (pepe_2.sizex / 2), pepe_2.y - (pepe_2.sizey / 2), pepe_2.sizex, pepe_2.sizey);
                else if (time_in_timer_look2 >= 14000)
                    g.DrawImage(pepe_2.img_pepe_right_look1, pepe_2.x - (pepe_2.sizex / 2), pepe_2.y - (pepe_2.sizey / 2), pepe_2.sizex, pepe_2.sizey);
            }
            if (!pepe_2.left_right)
            {
                if (time_in_timer_look2 >= 15800)
                    time_in_timer_look2 = 0;
                else if (time_in_timer_look2 >= 15400)
                    g.DrawImage(pepe_2.img_pepe_left_look1, pepe_2.x - (pepe_2.sizex / 2), pepe_2.y - (pepe_2.sizey / 2), pepe_2.sizex, pepe_2.sizey);
                else if (time_in_timer_look2 >= 15000)
                    g.DrawImage(pepe_2.img_pepe_left_look2, pepe_2.x - (pepe_2.sizex / 2), pepe_2.y - (pepe_2.sizey / 2), pepe_2.sizex, pepe_2.sizey);
                else if (time_in_timer_look2 >= 14000)
                    g.DrawImage(pepe_2.img_pepe_left_look1, pepe_2.x - (pepe_2.sizex / 2), pepe_2.y - (pepe_2.sizey / 2), pepe_2.sizex, pepe_2.sizey);
            }

            if (trigerBox)
            {
                if (time_in_timer >= 4500)
                {
                    g.DrawImage(heart.heart_full, heart.x - (heart.sizex / 2), heart.y, heart.sizex, heart.sizey);

                    if (pepe_1.left_right)
                        g.DrawImage(pepe_1.img_pepe_right_smile, pepe_1.x - (pepe_1.sizex / 2), pepe_1.y - (pepe_1.sizey / 2), pepe_1.sizex, pepe_1.sizey);
                    else
                        g.DrawImage(pepe_1.img_pepe_left_smile, pepe_1.x - (pepe_1.sizex / 2), pepe_1.y - (pepe_1.sizey / 2), pepe_1.sizex, pepe_1.sizey);
                    if (pepe_2.left_right)
                        g.DrawImage(pepe_2.img_pepe_right_smile, pepe_2.x - (pepe_2.sizex / 2), pepe_2.y - (pepe_2.sizey / 2), pepe_2.sizex, pepe_2.sizey);
                    else
                        g.DrawImage(pepe_2.img_pepe_left_smile, pepe_2.x - (pepe_2.sizex / 2), pepe_2.y - (pepe_2.sizey / 2), pepe_2.sizex, pepe_2.sizey);
                    time_in_timer_look1 = 0;
                    time_in_timer_look2 = 0;
                }
                else if (time_in_timer >= 4000)
                    g.DrawImage(heart.heart_4, heart.x - (heart.sizex / 2), heart.y, heart.sizex, heart.sizey);
                else if (time_in_timer >= 3500)
                    g.DrawImage(heart.heart_3, heart.x - (heart.sizex / 2), heart.y, heart.sizex, heart.sizey);
                else if (time_in_timer >= 3000)
                    g.DrawImage(heart.heart_2, heart.x - (heart.sizex / 2), heart.y, heart.sizex, heart.sizey);
                else if (time_in_timer >= 2500)
                    g.DrawImage(heart.heart_1, heart.x - (heart.sizex / 2), heart.y, heart.sizex, heart.sizey);
                else if (time_in_timer >= 2000)
                    g.DrawImage(heart.heart_void, heart.x - (heart.sizex / 2), heart.y, heart.sizex, heart.sizey);
            }

        }

        private void Pepe_Move(Pepe pepe)
        {
            if (pepe.x <= this.Width - pepe.sizex || pepe.x >= 0 + pepe.sizex)
                pepe.x += pepe.runXValue;
            if (pepe.y <= this.Height - pepe.sizey || pepe.y >= 0 + pepe.sizey)
                pepe.y += pepe.runYValue;
            if (pepe.x > this.Width - pepe.sizex / 1.35f)
                pepe.x = this.Width - pepe.sizex / 1.35f;
            else if (pepe.x < 0 + pepe.sizex / 2)
                pepe.x = 0 + pepe.sizex / 2;
            if (pepe.y > this.Height - pepe.sizey / 1.15f)
                pepe.y = this.Height - pepe.sizey / 1.15f;
            else if (pepe.y < pagar.y + (this.Height - 540) - pepe.sizey / 4f)
                pepe.y = pagar.y + (this.Height - 540) - pepe.sizey / 4f;
        }
    }
}
