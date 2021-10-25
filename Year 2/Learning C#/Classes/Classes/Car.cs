using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    internal class Car
    {
        public int height;
        private int width;
        protected string brand;
        internal string name;
        private protected int id;
        protected internal int number;

        // Працюємо з полями в самому класі
        public int Width
        {
            set { this.width = value; }
            get { return this.width; }
        }
        public string Brand
        {
            set { this.brand = value; }
        }
        public string Name
        {
            set { this.name = value; }
        }
    }
}
