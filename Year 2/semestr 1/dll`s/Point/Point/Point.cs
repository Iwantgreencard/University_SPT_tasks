using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    internal class Point
    {
        protected int x;
        protected int y;


        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public Point()
        {

        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void set_x(int x)
        {
            this.x = x;
        }
        public void set_y(int y)
        {
            this.y = y;
        }
        public virtual void set_coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual void show_coordinates()
        {
            Console.WriteLine($"| x = {this.x} ");
            Console.WriteLine($"| y = {this.y} ");

        }
        public virtual double distance_bettwen_points(Point a, Point b)
        {
            double distance = Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2));
            return distance;
        } 
    }

}
