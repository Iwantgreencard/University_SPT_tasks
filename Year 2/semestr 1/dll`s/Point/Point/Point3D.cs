using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Point3D : Point
    {
        protected int z;
        public Point3D()
        {

        }
        public Point3D(int x, int y, int z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public int Y
        {
            get { return y; }
        }
        public void set_z(int z)
        {
            this.z = z;
        }
        public void set_coordinates(int x, int y, int z)
        {
            base.set_coordinates(x, y);
            this.z = z;
        }
        public override void show_coordinates()
        {
            base.show_coordinates();
            Console.WriteLine($"| z = {this.z} ");
        }
        public double distance_bettwen_points(Point3D a, Point3D b)
        {
            double distance = Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2) + Math.Pow(b.z - a.z, 2));
            return distance;
        }
    }
}
