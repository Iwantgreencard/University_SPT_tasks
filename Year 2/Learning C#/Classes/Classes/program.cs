using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    internal class Ride : Car
    {
        public Ride(int id)
        {
            this.id = id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
        }
    }
}