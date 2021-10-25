using System;
using System.Collections.Generic;
using System.Text;
using lab_15;

namespace First_Task___lab_18
{
    class Point3D : Point
    {
        private int z;

        public Point3D()
        {

        }
        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public int Z
        {
            get { return z; }
        }
        public void set_z(int z)
        {
            this.z = z;
        }
        public virtual void set_coordinates(int x, int y, int z)
        {
            base.set_coordinates(x, y);
            this.z = z;
        }
        public override void show_coordinates()
        {
            base.show_coordinates();
            Console.WriteLine($"| z = {this.z} ");
        }
        public static Point3D operator +(Point3D a, Point3D b)
        {
            Point3D result = new Point3D(a.x + b.x, a.y + b.y, a.z + b.z);
            return result;
        }
    }
}
